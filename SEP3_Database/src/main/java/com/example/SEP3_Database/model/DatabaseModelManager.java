package com.example.SEP3_Database.model;

import com.example.SEP3_Database.jdbc.JDBC_interface;
import com.example.SEP3_Database.jdbc.Jdbc_User;
import com.example.SEP3_Database.model.domain.list.groupList.ChatGroupList;
import com.example.SEP3_Database.model.domain.list.message.GroupMessageList;
import com.example.SEP3_Database.model.domain.list.message.PrivateMessageList;
import com.example.SEP3_Database.model.domain.list.postList.PostList;
import com.example.SEP3_Database.model.domain.list.userList.AccountList;
import com.example.SEP3_Database.model.domain.unit.group.ChatGroup;
import com.example.SEP3_Database.model.domain.unit.message.GroupMessage;
import com.example.SEP3_Database.model.domain.unit.message.PrivateMessage;
import com.example.SEP3_Database.model.domain.unit.post.Post;
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

    private DatabaseModelManager()
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
                jdbc.InsertChatGroupTable(newChatGroup);
            }
            chatGroupList.addNewGroup(newChatGroup);
            DataFileContext.updateChatGroupListData(chatGroupList);
        }
    }

    @Override
    public ChatGroupList getAllChatGroup() {
        if (databaseOnline)
        {
            return jdbc.getChatGroupList();
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
                jdbc.updateChatGroup(newChatGroup);
            }
            chatGroupList.updateGroup(newChatGroup);
            DataFileContext.updateChatGroupListData(chatGroupList);
        }
    }

    @Override
    public void removeChatGroup(String groupId) {
        ChatGroupList chatGroupList = DataFileContext.readChatGroupListData();
        GroupMessageList groupMessageList = DataFileContext.readGroupMessageListData();
        if (chatGroupList!=null&&groupMessageList!=null)
        {
            if (databaseOnline)
            {
                //jdbc.
            }
            chatGroupList.removeGroupByGroupId(groupId);
            groupMessageList.removeMessageById(null,groupId);
            DataFileContext.updateChatGroupListData(chatGroupList);
            DataFileContext.updateGroupMessageListData(groupMessageList);
        }
    }

    @Override
    public void addPrivateMessage(PrivateMessage newMessage) {
        PrivateMessageList privateMessageList = DataFileContext.readPrivateMessageListData();
        if (privateMessageList!=null)
        {
            if (databaseOnline)
            {
                jdbc.InsertIntoPrivateMessageTable(newMessage);
            }
            privateMessageList.addMessage(newMessage);
            DataFileContext.updatePrivateMessageListData(privateMessageList);
        }
    }

    @Override
    public PrivateMessageList getAllPrivateMessage() {
        if (databaseOnline)
        {
            return jdbc.getPrivateMessageList();
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
                jdbc.InsertIntoGroupMessageTable(newMessage);
            }
            groupMessageList.addMessage(newMessage);
            DataFileContext.updateGroupMessageListData(groupMessageList);
        }
    }

    @Override
    public GroupMessageList getAllGroupMessage() {
        if (databaseOnline)
        {
            return jdbc.getGroupMessageList();
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

    @Override
    public void addPost(Post newPost) {
        PostList postList = DataFileContext.readPostListData();
        if (postList!=null)
        {
            if (databaseOnline)
            {
                //jdbc.;
            }
            postList.addPost(newPost);
            DataFileContext.updatePostListData(postList);
        }
    }

    @Override
    public PostList getAllPost() {
        if (databaseOnline)
        {
            //return jdbc.;
        }
        return DataFileContext.readPostListData();
    }

    @Override
    public void updatePost(Post newPost) {
        PostList postList = DataFileContext.readPostListData();
        if (postList!=null)
        {
            if (databaseOnline)
            {
                //jdbc.;
            }
            postList.updatePost(newPost);
            DataFileContext.updatePostListData(postList);
        }
    }

    @Override
    public void removePost(String postId) {
        PostList postList = DataFileContext.readPostListData();
        if (postList!=null)
        {
            if (databaseOnline)
            {
                //jdbc.;
            }
            postList.removePostByPostId(postId);
            DataFileContext.updatePostListData(postList);
        }
    }
}
