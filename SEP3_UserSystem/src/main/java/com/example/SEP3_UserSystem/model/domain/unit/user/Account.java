package com.example.SEP3_UserSystem.model.domain.unit.user;
import com.example.SEP3_UserSystem.model.domain.list.userList.FriendSettingList;

public class Account extends BasicInformation {
    private String Password;
    private FriendSettingList FriendSettingList;

    public Account(String id, String userName,String password) {
        super(id, userName);
        Password = password;
        FriendSettingList = new FriendSettingList();
    }

    private Account(String id, String userName, Birthday birthday, String password, FriendSettingList friendSettingList,UserState userState) {
        this(id, userName, password);
        setBirthday(birthday);
        setUserState(userState);
        FriendSettingList = friendSettingList;
    }

    public boolean checkPassword(String password)
    {
        if (password==null)
        {
            return false;
        }
        else
        {
            return Password.equals(password);
        }
    }

    public boolean checkPassword(Account otherAccount)
    {
        return otherAccount.getId().equals(getId())&&otherAccount.checkPassword(Password);
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

    public String changePassWord(Account oldAccount,Account newAccount) {
        if (getId().equals(newAccount.getId())&&checkPassword(oldAccount))
        {
            return changePassWord(oldAccount.Password,newAccount.Password);
        }
        else
        {
            return "Wrong change.";
        }
    }

    public FriendSettingList getFriendSettingList() {
        return FriendSettingList;
    }

    public void setFriendSettingList(FriendSettingList friendSettingList) {
        FriendSettingList = friendSettingList;
    }

    public void update(Account account)
    {
        update(account.getUserName(),account.getBirthday());
        FriendSettingList = account.getFriendSettingList();
    }

    public Account copy() {
        return new Account(getId(),getUserName(),getBirthday(),Password,FriendSettingList.copy(),getUserState().copy());
    }

    public Account toClient() {
        return new Account(getId(),getUserName(),getBirthday(),"",FriendSettingList.copy(),getUserState().copy());
    }
}
