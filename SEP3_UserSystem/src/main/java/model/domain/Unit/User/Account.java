package model.domain.Unit.User;
import model.domain.List.UserList.FriendSettingList;

import java.util.Date;

public class Account extends UserInformation {
    private String Password;
    private FriendSettingList FriendSettingList;

    public Account(String id, String userName,String password) {
        super(id, userName);
        Password = password;
        FriendSettingList = new FriendSettingList();
    }

    private Account(String id, String userName, Date birthday, String password, FriendSettingList friendSettingList) {
        this(id, userName, password);
        setBirthday(birthday);
        FriendSettingList = friendSettingList;
    }

    public String changePassWord(String oldPassword,String newPassword) {
        if (Password.equals(oldPassword))
        {
            Password = newPassword;
            return null;
        }
        else
        {
            return "Wrong password.";
        }
    }

    public FriendSettingList getFriendSettingList() {
        return FriendSettingList;
    }

    public void setFriendSettingList(model.domain.List.UserList.FriendSettingList friendSettingList) {
        FriendSettingList = friendSettingList;
    }

    public void update(Account account)
    {
        update(account.getUserName(),account.getBirthday());
        FriendSettingList = account.getFriendSettingList();
    }

    public Account copy() {
        return new Account(getId(),getUserName(),getBirthday(),Password,FriendSettingList.copy());
    }
}
