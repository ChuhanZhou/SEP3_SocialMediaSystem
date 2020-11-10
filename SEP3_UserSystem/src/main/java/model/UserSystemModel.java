package model;

import model.domain.list.userList.FriendList;
import model.domain.unit.user.Account;
import utility.NamedPropertyChangeSubject;

public interface UserSystemModel extends NamedPropertyChangeSubject
{
    Account addNewAccount(String name,String password);
    String login(String id,String password);
    void logoff(String id);
    Account getAccountById(String id);
    Account getAccountByIdAndPassword(String id,String password);
    boolean hasId(String id);
    String changePassword(String id,String oldPassword,String newPassword);
    String changePassword(Account oldAccount,Account newAccount);
    String updateBasicInformation(Account oldAccount,Account newAccount);
    String addNewFriend();
    FriendList getFriendListByAccount(Account account);
    void removeFriend(Account account,String friendId);
}
