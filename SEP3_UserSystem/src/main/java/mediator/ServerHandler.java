package mediator;

import com.google.gson.Gson;
import mediator.information.*;
import model.UserSystemModel;
import model.domain.list.userList.AccountList;
import model.domain.unit.user.Account;
import model.domain.unit.user.Friend;

import java.beans.PropertyChangeEvent;
import java.beans.PropertyChangeListener;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.Socket;

public class ServerHandler implements Runnable, PropertyChangeListener {
    private Socket socket;
    private BufferedReader in;
    private PrintWriter out;
    private UserSystemModel userSystemModel;
    private Gson gson;
    private String id;
    private boolean connect;
    private boolean login;

    public ServerHandler(UserSystemModel userSystemModel,Socket socket)
    {
        this.userSystemModel = userSystemModel;
        this.socket = socket;
        gson = new Gson();
        try
        {
            in = new BufferedReader(new InputStreamReader(this.socket.getInputStream()));
            out = new PrintWriter(this.socket.getOutputStream(),true);
        }
        catch (IOException e)
        {
            e.printStackTrace();
        }
        connect = true;
        login = false;
        this.userSystemModel.addListener("updateAccount",this);
    }

    public void close()
    {
        try
        {
            socket.close();
            in.close();
            out.close();
        }
        catch (IOException e)
        {
            e.printStackTrace();
        }
    }

    private void sendErrorPackage()
    {
        sendInformationPackage(new ErrorPackage(null,false));
    }

    private void sendErrorPackage(String error)
    {
        if (error.isEmpty())
        {
            sendErrorPackage();
        }
        else
        {
            sendInformationPackage(new ErrorPackage(error,true));
        }
    }

    private void sendInformationPackage(InformationPackage informationPackage)
    {
        String send = gson.toJson(informationPackage);
        out.println(send);
    }

    private void login(String id,String password)
    {
        String receive = userSystemModel.login(id,password);
        if (receive==null)
        {
            afterLogin(userSystemModel.getAccountByIdAndPassword(id, password));
        }
        else
        {
            sendErrorPackage(receive);
        }
    }

    private void register(LoginOrRegisterPackage receivePackage)
    {
        Account newAccount = userSystemModel.addNewAccount(receivePackage.getName(),receivePackage.getPassword());
        login(newAccount.getId(),receivePackage.getPassword());
    }

    private void afterLogin(Account account)
    {
        try
        {
            id = account.getId();
            String receive;
            InformationPackage informationPackage;
            sendInformationPackage(new AccountPackage(account,"update"));
            sendInformationPackage(new FriendPackage(userSystemModel.getFriendListByAccount(account),"update"));
            login = true;
            while (login)
            {
                receive = in.readLine();
                informationPackage = gson.fromJson(receive,InformationPackage.class);
                if (informationPackage==null)
                {
                    break;
                }
                switch (informationPackage.getInformationType())
                {
                    case LOGIN:
                        break;
                    case ACCOUNT:
                        AccountPackage accountPackage = gson.fromJson(receive,AccountPackage.class);
                        Account oldAccount = accountPackage.getSendList().getAccountByIndex(0);
                        Account newAccount = accountPackage.getSendList().getAccountByIndex(1);
                        switch (accountPackage.getKeyword())
                        {
                            case "changePassword":
                                sendErrorPackage(userSystemModel.changePassword(oldAccount,newAccount));
                                break;
                            case "updateBasicInformation":
                                sendErrorPackage(userSystemModel.updateBasicInformation(oldAccount,newAccount));
                                break;
                            case "logoff":
                                userSystemModel.logoff(oldAccount.getId());
                                break;
                        }
                        break;
                    case FRIEND:
                        break;
                    case ERROR:
                        break;
                    default:
                        break;
                }
            }
        }
        catch (Exception e)
        {
            userSystemModel.logoff(id);
        }

    }

    @Override
    public void run() {
        String receive;
        try
        {
            while (connect)
            {
                receive = in.readLine();
                InformationPackage informationPackage = gson.fromJson(receive,InformationPackage.class);
                if (informationPackage.getInformationType()==InformationType.LOGIN)
                {
                    LoginOrRegisterPackage receivePackage = gson.fromJson(receive,LoginOrRegisterPackage.class);
                    switch (receivePackage.getKeyword())
                    {
                        case "login":
                            login(receivePackage.getId(),receivePackage.getPassword());
                            break;
                        case "register":
                            register(receivePackage);
                            break;
                        default:
                            sendErrorPackage("Wrong keyword!");
                            break;
                    }
                }
            }
        }
        catch (IOException e)
        {
            close();
            connect = false;
            login = false;
        }
    }

    @Override
    public void propertyChange(PropertyChangeEvent evt) {
        if (login)
        {
            switch (evt.getPropertyName())
            {
                case "updateAccount":
                    Account account = (Account) evt.getNewValue();
                    if (account.getId().equals(id))
                    {
                        sendInformationPackage(new AccountPackage(account,"update"));
                    }
                    else if (userSystemModel.getAccountById(id).getFriendSettingList().getFriendSettingById(account.getId())!=null)
                    {
                        sendInformationPackage(new FriendPackage(new Friend(account),"update"));
                    }
                    break;
            }
        }
    }
}
