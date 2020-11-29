package com.example.SEP3_Database.persistence;

import com.example.SEP3_Database.model.domain.list.groupList.ChatGroupList;
import com.example.SEP3_Database.model.domain.list.message.GroupMessageList;
import com.example.SEP3_Database.model.domain.list.message.PrivateMessageList;
import com.google.gson.Gson;
import com.example.SEP3_Database.model.domain.list.userList.AccountList;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.Scanner;

public class DataFileContext {
    private static Gson gson = new Gson();
    private static String address = "SEP3_SocialMediaSystem/SEP3_Database/src/main/java/com/example/SEP3_Database/dataFile";

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

    public static ChatGroupList readChatGroupListData()
    {
        try
        {
            File file = new File(address + "ChatGroupList.json");
            if (!file.exists())
            {
                updateChatGroupListData(new ChatGroupList());
            }
            Scanner input = new Scanner(file);
            String json = input.nextLine();
            ChatGroupList chatGroupList = gson.fromJson(json,ChatGroupList.class);
            return chatGroupList;
        }
        catch (FileNotFoundException e)
        {
            e.printStackTrace();
        }
        return null;
    }

    public static void updateChatGroupListData(ChatGroupList chatGroupList)
    {
        try
        {
            String json = gson.toJson(chatGroupList);
            File file = new File(address + "ChatGroupList.json");
            PrintWriter out = new PrintWriter(file);
            out.print(json);
            out.close();
        }
        catch (FileNotFoundException e)
        {
            e.printStackTrace();
        }
    }

    public static PrivateMessageList readPrivateMessageListData()
    {
        try
        {
            File file = new File(address + "PrivateMessageList.json");
            if (!file.exists())
            {
                updatePrivateMessageListData(new PrivateMessageList());
            }
            Scanner input = new Scanner(file);
            String json = input.nextLine();
            PrivateMessageList privateMessageList = gson.fromJson(json,PrivateMessageList.class);
            return privateMessageList;
        }
        catch (FileNotFoundException e)
        {
            e.printStackTrace();
        }
        return null;
    }

    public static void updatePrivateMessageListData(PrivateMessageList privateMessageList)
    {
        try
        {
            String json = gson.toJson(privateMessageList);
            File file = new File(address + "PrivateMessageList.json");
            PrintWriter out = new PrintWriter(file);
            out.print(json);
            out.close();
        }
        catch (FileNotFoundException e)
        {
            e.printStackTrace();
        }
    }

    public static GroupMessageList readGroupMessageListData()
    {
        try
        {
            File file = new File(address + "GroupMessageList.json");
            if (!file.exists())
            {
                updateGroupMessageListData(new GroupMessageList());
            }
            Scanner input = new Scanner(file);
            String json = input.nextLine();
            GroupMessageList groupMessageList = gson.fromJson(json,GroupMessageList.class);
            return groupMessageList;
        }
        catch (FileNotFoundException e)
        {
            e.printStackTrace();
        }
        return null;
    }

    public static void updateGroupMessageListData(GroupMessageList groupMessageList)
    {
        try
        {
            String json = gson.toJson(groupMessageList);
            File file = new File(address + "GroupMessageList.json");
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
