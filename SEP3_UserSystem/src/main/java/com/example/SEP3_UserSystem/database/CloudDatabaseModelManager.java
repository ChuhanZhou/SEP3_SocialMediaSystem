package com.example.SEP3_UserSystem.database;

import com.example.SEP3_UserSystem.model.UserSystemModelForDatabaseSystem;
import com.example.SEP3_UserSystem.model.UserSystemModelManager;
import com.example.SEP3_UserSystem.model.domain.list.userList.AccountList;
import com.example.SEP3_UserSystem.model.domain.unit.user.Account;
import com.google.gson.Gson;

import java.io.*;
import java.net.HttpURLConnection;
import java.net.URL;

public class CloudDatabaseModelManager implements CloudDatabaseModel {
    private String urlAddress = "http://localhost:8070/api/account/";
    private URL url;
    private OutputStreamWriter out;
    private BufferedReader in;
    private Gson gson;
    private UserSystemModelForDatabaseSystem userSystemModel;

    public CloudDatabaseModelManager(UserSystemModelManager userSystemModel)
    {
        gson = new Gson();
        this.userSystemModel = userSystemModel;
    }

    @Override
    public void addAccount(Account newAccount) {
        try
        {
            newAccount = newAccount.copy();
            newAccount.getUserStatus().logoff();
            url = new URL(urlAddress);
            HttpURLConnection connection = (HttpURLConnection) url.openConnection();
            connection.setRequestMethod("POST");
            connection.setDoOutput(true);
            connection.setDoInput(true);
            connection.setRequestProperty("connection", "keep-alive");
            connection.setRequestProperty("Content-Type", "application/form-data");
            connection.connect();
            out = new OutputStreamWriter(connection.getOutputStream(),"UTF-8");
            out.write(gson.toJson(newAccount));
            System.out.println("Post Send: "+gson.toJson(newAccount));
            out.flush();
            out.close();
            in = new BufferedReader(new InputStreamReader(connection.getInputStream(),"UTF-8"));
            String receive = in.readLine();
            System.out.println("API Part Receive: "+receive);
            in.close();
            connection.disconnect();
            System.out.println("Post end");
            userSystemModel.databaseSystemOnline();
        }
        catch (Exception e)
        {
            System.out.println("Database System offline.");
            userSystemModel.databaseSystemOffline();
            //e.printStackTrace();
        }
    }

    @Override
    public AccountList getAllAccount() {
        try
        {
            url = new URL(urlAddress);
            HttpURLConnection connection = (HttpURLConnection) url.openConnection();
            connection.setRequestMethod("GET");
            connection.setRequestProperty("Content-Type", "application/json");
            connection.connect();
            in = new BufferedReader(new InputStreamReader(connection.getInputStream(),"UTF-8"));
            String receive = in.readLine();
            in.close();
            connection.disconnect();
            System.out.println("Get Receive:"+receive);
            AccountList accountList = gson.fromJson(receive,AccountList.class);
            userSystemModel.databaseSystemOnline();
            return accountList;
        }
        catch (Exception e)
        {
            System.out.println("Database System offline.");
            userSystemModel.databaseSystemOffline();
            //e.printStackTrace();
        }
        return new AccountList();
    }

    @Override
    public void updateUser(Account newAccount) {
        try
        {
            newAccount = newAccount.copy();
            newAccount.getUserStatus().logoff();
            url = new URL(urlAddress);
            HttpURLConnection connection = (HttpURLConnection) url.openConnection();
            connection.setRequestMethod("PUT");
            connection.setDoOutput(true);
            connection.setDoInput(true);
            connection.setRequestProperty("connection", "keep-alive");
            connection.setRequestProperty("Content-Type", "application/form-data");
            connection.connect();
            out = new OutputStreamWriter(connection.getOutputStream(),"UTF-8");
            out.write(gson.toJson(newAccount));
            System.out.println("Put Send: "+gson.toJson(newAccount));
            out.flush();
            out.close();
            in = new BufferedReader(new InputStreamReader(connection.getInputStream(),"UTF-8"));
            String receive = in.readLine();
            System.out.println("API Part Receive: "+receive);
            in.close();
            connection.disconnect();
            System.out.println("Put end");
            userSystemModel.databaseSystemOnline();
        }
        catch (Exception e)
        {
            System.out.println("Database System offline.");
            userSystemModel.databaseSystemOffline();
            //e.printStackTrace();
        }
    }

    @Override
    public void removeAccount(Account account) {
        try
        {
            url = new URL(urlAddress);
            HttpURLConnection connection = (HttpURLConnection) url.openConnection();
            connection.setRequestMethod("DELETE");
            connection.setDoOutput(true);
            connection.setDoInput(true);
            connection.setRequestProperty("connection", "keep-alive");
            connection.setRequestProperty("Content-Type", "application/form-data");
            connection.connect();
            out = new OutputStreamWriter(connection.getOutputStream(),"UTF-8");
            out.write(gson.toJson(account));
            System.out.println("Delete Send: "+gson.toJson(account));
            out.flush();
            out.close();
            in = new BufferedReader(new InputStreamReader(connection.getInputStream(),"UTF-8"));
            String receive = in.readLine();
            System.out.println("API Part Receive: "+receive);
            in.close();
            connection.disconnect();
            System.out.println("Delete end");
            userSystemModel.databaseSystemOnline();
        }
        catch (Exception e)
        {
            System.out.println("Database System offline.");
            userSystemModel.databaseSystemOffline();
            //e.printStackTrace();
        }
    }
}
