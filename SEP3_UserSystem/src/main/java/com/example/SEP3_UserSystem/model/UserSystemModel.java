package com.example.SEP3_UserSystem.model;

import com.example.SEP3_UserSystem.model.domain.list.userList.FriendList;
import com.example.SEP3_UserSystem.model.domain.unit.user.Account;
import com.example.SEP3_UserSystem.model.domain.unit.user.FriendSetting;
import com.example.SEP3_UserSystem.utility.NamedPropertyChangeSubject;

public interface UserSystemModel extends NamedPropertyChangeSubject
{
    Account addNewAccount(String name, String password);
    String login(String id,String password);
    void logoff(String id);
    Account getAccountById(String id);
    Account getAccountByIdAndPassword(String id,String password);
    boolean hasId(String id);
    String changePassword(String id,String oldPassword,String newPassword);
    String changePassword(Account oldAccount,Account newAccount);
    String updateBasicInformation(Account oldAccount,Account newAccount);
    String updateFriendSetting(FriendSetting newFriendSetting);
    String addNewFriend(String id,FriendSetting friendSetting);
    FriendList getFriendListByAccount(Account account);
    void removeFriend(Account account,String friendId);
}
