package com.example.SEP3_UserSystem.database;

import com.example.SEP3_UserSystem.model.domain.list.userList.AccountList;
import com.example.SEP3_UserSystem.model.domain.unit.user.Account;
import com.google.gson.Gson;
import com.google.gson.JsonObject;
import org.springframework.web.bind.annotation.PostMapping;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;
import java.net.http.HttpRequest;

public class CloudDatabaseModelManager implements CloudDatabaseModel {
    private String urlAddress = "http://localhost:8060/api/account";
    private URL url;
    private OutputStreamWriter out;
    private BufferedReader in;
    private Gson gson;

    public CloudDatabaseModelManager()
    {
        gson = new Gson();
        try
        {
            url = new URL(urlAddress);
        }
        catch (MalformedURLException e)
        {
            e.printStackTrace();
        }
    }

    @Override
    public void addAccount(Account newAccount) {
        try
        {
            HttpURLConnection connection = (HttpURLConnection) url.openConnection();
            connection.setRequestMethod("POST");
            connection.setRequestProperty("Account", "application/json");
            connection.setDoOutput(true);
            connection.connect();
            out = new OutputStreamWriter(connection.getOutputStream(),"UTF-8");
            JsonObject jsonObject = new JsonObject();
            jsonObject.addProperty("newAccount",gson.toJson(newAccount));
            out.write(jsonObject.toString());
            out.flush();
            out.close();
            System.out.println(1);
        }
        catch (IOException e)
        {
            e.printStackTrace();
        }
    }

    @Override
    public AccountList getAllAccount() {
        try
        {
            HttpURLConnection connection = (HttpURLConnection) url.openConnection();
            connection.setRequestMethod("GET");
            connection.setRequestProperty("AccountList", "application/json");
            connection.connect();
            in = new BufferedReader(new InputStreamReader(connection.getInputStream(),"UTF-8"));
            String receive = in.readLine();
            in.close();
            System.out.println(receive);
            AccountList accountList = gson.fromJson(receive,AccountList.class);
            return accountList;
        }
        catch (IOException e)
        {
            e.printStackTrace();
        }
        return null;
    }

    @Override
    public void updateUser(Account newAccount) {
        System.out.println(3);
    }

    @Override
    public void removeAccount(Account account) {

    }
}
