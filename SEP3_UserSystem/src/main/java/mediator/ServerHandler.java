package mediator;

import com.google.gson.Gson;
import mediator.information.ErrorPackage;
import mediator.information.InformationPackage;
import model.UserSystemModel;

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
        this.userSystemModel.addListener("",this);
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

    private void login()
    {

    }

    private void register()
    {

    }

    @Override
    public void run() {
        String receive;
        try
        {
            while (connect)
            {
                receive = in.readLine();
                if (receive!=null)
                {
                    switch (receive)
                    {
                        case "login":
                            login();
                            break;
                        case "register":
                            register();
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
            //e.printStackTrace();
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
                case "":
                    break;
            }
        }
    }
}
