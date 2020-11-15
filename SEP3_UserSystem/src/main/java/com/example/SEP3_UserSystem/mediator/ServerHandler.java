package com.example.SEP3_UserSystem.mediator;

import com.example.SEP3_UserSystem.mediator.information.*;
import com.example.SEP3_UserSystem.model.UserSystemModel;
import com.example.SEP3_UserSystem.model.domain.unit.user.Account;
import com.example.SEP3_UserSystem.model.domain.unit.user.Friend;
import com.google.gson.Gson;

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
        this.userSystemModel.addListener("updateFriendSetting",this);

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
        if (error==null)
        {
            sendErrorPackage();
        }
        else
        {
            System.out.println("Error:"+error);
            sendInformationPackage(new ErrorPackage(error,true));
        }
    }

    private void sendInformationPackage(InformationPackage informationPackage)
    {
        String send = gson.toJson(informationPackage);
        System.out.println("Send:"+send);
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
            sendInformationPackage(new AccountPackage(account.toClient(),"update"));
            sendInformationPackage(new FriendPackage(userSystemModel.getFriendListByAccount(account),"update"));
            login = true;
            while (login)
            {
                receive = in.readLine();
                System.out.println("Receive:"+receive);
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
                        System.out.println("ACCOUNT:"+accountPackage.getKeyword());
                        switch (accountPackage.getKeyword())
                        {
                            case "changePassword":
                                sendErrorPackage(userSystemModel.changePassword(oldAccount,newAccount));
                                break;
                            case "updateBasicInformation":
                                String error = userSystemModel.updateBasicInformation(oldAccount,newAccount);
                                sendErrorPackage(error);
                                break;
                            case "logoff":
                                userSystemModel.logoff(oldAccount.getId());
                                sendErrorPackage();
                                login = false;
                                break;
                        }
                        break;
                    case FRIEND:
                        break;
                    case ERROR:
                        break;
                    case SEARCH:
                        SearchPackage searchPackage = gson.fromJson(receive,SearchPackage.class);
                        switch (searchPackage.getKeyword())
                        {
                            case "hasUser":
                                sendErrorPackage(String.valueOf(userSystemModel.hasId(searchPackage.getId())));
                                break;
                            default:
                                break;
                        }
                        break;
                    case SETTING:
                        FriendSettingPackage friendSettingPackage = gson.fromJson(receive,FriendSettingPackage.class);
                        switch (friendSettingPackage.getKeyword())
                        {
                            case "addNewFriend":

                                break;
                            case "":
                                break;
                        }
                        break;
                    default:
                        sendErrorPackage("Wrong package.");
                        break;
                }
            }
        }
        catch (Exception e)
        {
            e.printStackTrace();
            userSystemModel.logoff(id);
        }
        System.out.println("Connection with User[" + id + "] is disconnected.");
    }

    @Override
    public void run() {
        String receive;
        try
        {
            while (connect)
            {
                receive = in.readLine();
                System.out.println("Receive:"+receive);
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
                    break;
                }
            }
        }
        catch (IOException e)
        {
            e.printStackTrace();
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
                        sendInformationPackage(new AccountPackage(account.toClient(),"update"));
                    }
                    else if (userSystemModel.getAccountById(id).getFriendSettingList().getFriendSettingById(account.getId())!=null)
                    {
                        sendInformationPackage(new FriendPackage(new Friend(account),"update"));
                    }
                    break;
                case "updateFriendSetting":
                    account = (Account) evt.getNewValue();
                    if (account.getId().equals(id))
                    {
                        sendInformationPackage(new AccountPackage(account.toClient(),"update"));
                    }
                    break;
            }
        }
    }
}
