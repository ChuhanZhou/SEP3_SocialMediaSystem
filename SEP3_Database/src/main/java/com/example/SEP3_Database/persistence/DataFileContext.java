package com.example.SEP3_Database.persistence;

import com.google.gson.Gson;
import com.example.SEP3_Database.model.domain.list.userList.AccountList;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.Scanner;

public class DataFileContext {
    private static Gson gson = new Gson();
    private static String address = "SEP3_SocialMediaSystem/SEP3_Database/src/main/java/com/example/SEP3_Database/";

    public static AccountList readAccountListData()
    {
        try
        {
            File file = new File(address + "AccountList.json");
            if (!file.exists())
            {
                updateAccountListData(new AccountList());
            }
            Scanner input = new Scanner(file);
            String json = input.nextLine();
            System.out.println(json);
            AccountList accountList = gson.fromJson(json,AccountList.class);
            return accountList;
        }
        catch (FileNotFoundException e)
        {
            e.printStackTrace();
        }
        return null;
    }

    public static void updateAccountListData(AccountList accountList)
    {
        try
        {
            String json = gson.toJson(accountList);
            File file = new File(address + "AccountList.json");
            PrintWriter out = new PrintWriter(file);
            out.print(json);
            out.close();
        }
        catch (FileNotFoundException e)
        {
            e.printStackTrace();
        }
    }
}
