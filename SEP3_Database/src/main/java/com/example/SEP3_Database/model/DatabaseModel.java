package com.example.SEP3_Database.model;

import com.example.SEP3_Database.model.domain.list.groupList.ChatGroupList;
import com.example.SEP3_Database.model.domain.list.message.GroupMessageList;
import com.example.SEP3_Database.model.domain.list.message.PrivateMessageList;
import com.example.SEP3_Database.model.domain.list.postList.PostList;
import com.example.SEP3_Database.model.domain.list.userList.AccountList;
import com.example.SEP3_Database.model.domain.unit.group.ChatGroup;
import com.example.SEP3_Database.model.domain.unit.message.GroupMessage;
import com.example.SEP3_Database.model.domain.unit.message.PrivateMessage;
import com.example.SEP3_Database.model.domain.unit.post.Post;
import com.example.SEP3_Database.model.domain.unit.user.Account;

public interface DatabaseModel {
    void addAccount(Account newAccount);
    AccountList getAllAccount();
    void updateUser(Account newAccount);
    void removeAccount(Account account);

    void addChatGroup(ChatGroup newChatGroup);
    ChatGroupList getAllChatGroup();
    void updateChatGroup(ChatGroup newChatGroup);
    void removeChatGroup(String groupId);

    void addPrivateMessage(PrivateMessage newMessage);
    PrivateMessageList getAllPrivateMessage();

    void addGroupMessage(GroupMessage newMessage);
    GroupMessageList getAllGroupMessage();
    void removeGroupMessage(String groupId);

    void addPost(Post newPost);
    PostList getAllPost();
    void updatePost(Post newPost);
    void removePost(String groupId);
}
