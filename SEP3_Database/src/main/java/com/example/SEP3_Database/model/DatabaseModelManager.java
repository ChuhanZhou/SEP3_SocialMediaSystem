package com.example.SEP3_Database.model;

import com.example.SEP3_Database.jdbc.JDBC_interface;
import com.example.SEP3_Database.jdbc.Jdbc_User;
import com.example.SEP3_Database.model.domain.list.groupList.ChatGroupList;
import com.example.SEP3_Database.model.domain.list.message.GroupMessageList;
import com.example.SEP3_Database.model.domain.list.message.PrivateMessageList;
import com.example.SEP3_Database.model.domain.list.userList.AccountList;
import com.example.SEP3_Database.model.domain.unit.group.ChatGroup;
import com.example.SEP3_Database.model.domain.unit.message.GroupMessage;
import com.example.SEP3_Database.model.domain.unit.message.PrivateMessage;
import com.example.SEP3_Database.persistence.DataFileContext;
import com.example.SEP3_Database.model.domain.unit.user.Account;

import java.util.ArrayList;

public class DatabaseModelManager implements DatabaseModel{
    private static DatabaseModelManager modelManager;
    private boolean databaseOnline;
    private JDBC_interface jdbc;

    public static DatabaseModel getModelManager()
    {
        if (modelManager == null)
        {
            modelManager = new DatabaseModelManager();
        }
        return modelManager;
    }

    public DatabaseModelManager()
    {
        jdbc = new Jdbc_User();
        databaseOnline = false;
        if (jdbc.init())
        {
            databaseOnline = true;
            jdbc.CreateDataBase();
            System.out.println("Connect to the Database.");
        }
    }

    @Override
    public void addAccount(Account newAccount) {
        AccountList accountList = DataFileContext.readAccountListData();
        if (accountList!=null)
        {
            if (databaseOnline)
            {
                jdbc.insertUserInTable(newAccount);
            }
            accountList.addNewAccount(newAccount);
            DataFileContext.updateAccountListData(accountList);
        }
    }

    @Override
    public AccountList getAllAccount() {
        if (databaseOnline)
        {
            ArrayList<Account> list = jdbc.getAccountList();
            AccountList accountList = new AccountList();
            for (int x=0;x<list.size();x++)
            {
                accountList.addNewAccount(list.get(x));
            }
            return accountList;
        }
        else
        {
            return DataFileContext.readAccountListData();
        }
    }

    @Override
    public void updateUser(Account newAccount) {
        AccountList accountList = DataFileContext.readAccountListData();
        if (accountList!=null)
        {
            if (databaseOnline)
            {
                jdbc.UpdateDataBaseInUserTable(newAccount);
            }
            accountList.updateAccount(newAccount);
            accountList.changePassword(newAccount);
            DataFileContext.updateAccountListData(accountList);
        }
    }

    @Override
    public void removeAccount(Account account) {
        AccountList accountList = DataFileContext.readAccountListData();
        if (accountList!=null)
        {
            if (databaseOnline)
            {
                //数据库方法：删除数据
            }
            accountList.removeAccountById(account.getId());
            DataFileContext.updateAccountListData(accountList);
        }
    }

    @Override
    public void addChatGroup(ChatGroup newChatGroup) {
        ChatGroupList chatGroupList = DataFileContext.readChatGroupListData();
        if (chatGroupList!=null)
        {
            if (databaseOnline)
            {
                //database code
            }
            chatGroupList.addNewGroup(newChatGroup);
            DataFileContext.updateChatGroupListData(chatGroupList);
        }
    }

    @Override
    public ChatGroupList getAllChatGroup() {
        if (databaseOnline)
        {
            //database code
        }
        return DataFileContext.readChatGroupListData();
    }

    @Override
    public void updateChatGroup(ChatGroup newChatGroup) {
        ChatGroupList chatGroupList = DataFileContext.readChatGroupListData();
        if (chatGroupList!=null)
        {
            if (databaseOnline)
            {
                //database code
            }
            chatGroupList.updateGroup(newChatGroup);
            DataFileContext.updateChatGroupListData(chatGroupList);
        }
    }

    @Override
    public void removeChatGroup(ChatGroup chatGroup) {
        ChatGroupList chatGroupList = DataFileContext.readChatGroupListData();
        if (chatGroupList!=null)
        {
            if (databaseOnline)
            {
                //database code
            }
            chatGroupList.removeGroupByGroupId(chatGroup.getGroupId());
            DataFileContext.updateChatGroupListData(chatGroupList);
        }
    }

    @Override
    public void addPrivateMessage(PrivateMessage newMessage) {
        PrivateMessageList privateMessageList = DataFileContext.readPrivateMessageListData();
        if (privateMessageList!=null)
        {
            if (databaseOnline)
            {
                //database code
            }
            privateMessageList.addMessage(newMessage);
            DataFileContext.updatePrivateMessageListData(privateMessageList);
        }
    }

    @Override
    public PrivateMessageList getAllPrivateMessage() {
        if (databaseOnline)
        {
            //database code
        }
        return DataFileContext.readPrivateMessageListData();
    }

    @Override
    public void addGroupMessage(GroupMessage newMessage) {
        GroupMessageList groupMessageList = DataFileContext.readGroupMessageListData();
        if (groupMessageList!=null)
        {
            if (databaseOnline)
            {
                //database code
            }
            groupMessageList.addMessage(newMessage);
            DataFileContext.updateGroupMessageListData(groupMessageList);
        }
    }

    @Override
    public GroupMessageList getAllGroupMessage() {
        if (databaseOnline)
        {
            //database code
        }
        return DataFileContext.readGroupMessageListData();
    }

    @Override
    public void removeGroupMessage(String groupId) {
        GroupMessageList groupMessageList = DataFileContext.readGroupMessageListData();
        if (groupMessageList!=null)
        {
            if (databaseOnline)
            {
                //database code
            }
            groupMessageList.removeMessageById(null,groupId);
            DataFileContext.updateGroupMessageListData(groupMessageList);
        }
    }
}
