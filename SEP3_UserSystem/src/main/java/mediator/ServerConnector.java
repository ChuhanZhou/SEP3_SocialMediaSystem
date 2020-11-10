package mediator;

import model.UserSystemModel;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

public class ServerConnector implements Runnable
{
    private UserSystemModel userSystemModel;
    private int PORT = 8888;
    private ServerSocket welcomeSocket;

    public ServerConnector(UserSystemModel userSystemModel)
    {
        this.userSystemModel = userSystemModel;
    }

    public void start() throws IOException
    {
        System.out.println("Starting UserSystem server...");
        welcomeSocket = new ServerSocket(PORT);

        while (true)
        {
            System.out.println("Wait for a client...");
            Socket socket = welcomeSocket.accept();
            System.out.println("Connect to a client...");
            ServerHandler server = new ServerHandler(userSystemModel,socket);
            Thread thread = new Thread(server);
            thread.setDaemon(true);
            thread.start();
        }
    }

    @Override public void run()
    {
        try
        {
            start();
        }
        catch (IOException e)
        {
            e.printStackTrace();
        }
    }
}
