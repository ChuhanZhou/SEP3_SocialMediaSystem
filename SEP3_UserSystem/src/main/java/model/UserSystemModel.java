package model;

import model.domain.list.userList.FriendList;
import model.domain.unit.user.Account;
import utility.NamedPropertyChangeSubject;

public interface UserSystemModel extends NamedPropertyChangeSubject
{
    String addNewAccount(Account newAccount);
    String login(String id,String password);
    void logoff(String id);
    Account getAccountByIdAndPassword(String id,String password);
    boolean hasId(String id);
    String changePassword(String id,String oldPassword,String newPassword);
    String updateUserInformation(Account account);
    String addNewFriend();
    FriendList getFriendListByIdAndPassword(String id,String password);
    void removeFriend(String id, String password,String friendId);
}
