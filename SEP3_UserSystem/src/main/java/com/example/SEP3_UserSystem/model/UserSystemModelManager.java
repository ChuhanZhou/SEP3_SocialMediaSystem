package com.example.SEP3_UserSystem.model;

import com.example.SEP3_UserSystem.model.domain.list.userList.FriendSettingList;
import com.example.SEP3_UserSystem.model.domain.unit.user.Account;
import com.example.SEP3_UserSystem.database.CloudDatabaseModel;
import com.example.SEP3_UserSystem.database.CloudDatabaseModelManager;
import com.example.SEP3_UserSystem.model.domain.list.userList.AccountList;
import com.example.SEP3_UserSystem.model.domain.list.userList.FriendList;
import com.example.SEP3_UserSystem.model.domain.unit.user.Friend;

import java.beans.PropertyChangeListener;
import java.beans.PropertyChangeSupport;

public class UserSystemModelManager implements UserSystemModel
{
    private AccountList accountList;
    private PropertyChangeSupport property;
    private CloudDatabaseModel cloudDatabaseModel;

    public UserSystemModelManager()
    {
        property = new PropertyChangeSupport(this);
        accountList = new AccountList();
        cloudDatabaseModel = new CloudDatabaseModelManager();
        accountList = cloudDatabaseModel.getAllAccount();
    }

    private String getRandomId()
    {
        String randomId = "";
        for (int x=0;x<8;x++)
        {
            int digit = (int) (Math.random() * 16 + 0);
            randomId += Integer.toHexString(digit).toUpperCase();
        }
        return randomId;
    }

    @Override
    public Account addNewAccount(String name, String password)
    {
        String newId = getRandomId();
        while (accountList.getAccountById(newId)!=null)
        {
            newId = getRandomId();
        }
        Account newAccount = new Account(newId,name,password);
        accountList.addNewAccount(newAccount);
        cloudDatabaseModel.addAccount(newAccount);
        return newAccount;
    }

    @Override
    public String login(String id, String password) {
        Account targetAccount = accountList.getAccountById(id);
        if (targetAccount!=null)
        {
            if (targetAccount.checkPassword(password))
            {
                if (!targetAccount.getUserState().isOnline())
                {
                    targetAccount.getUserState().login();
                    property.firePropertyChange("updateAccount",null,targetAccount);
                    return null;
                }
                else
                {
                    return "This account is online.";
                }
            }
        }
        return "Wrong Id or Password.";
    }

    @Override
    public void logoff(String id) {
        Account targetAccount = accountList.getAccountById(id);
        targetAccount.getUserState().logoff();
        property.firePropertyChange("updateAccount",null,targetAccount);
    }

    @Override
    public Account getAccountById(String id) {
        return accountList.getAccountById(id).copy();
    }

    @Override
    public Account getAccountByIdAndPassword(String id, String password) {
        Account targetAccount = accountList.getAccountById(id);
        if (targetAccount!=null)
        {
            if (targetAccount.checkPassword(password))
            {
                return targetAccount.copy();
            }
        }
        return null;
    }

    @Override
    public boolean hasId(String id) {
        return accountList.getAccountById(id)!=null;
    }

    @Override
    public String changePassword(String id, String oldPassword, String newPassword)
    {
        String result = accountList.changePassword(id, oldPassword, newPassword);
        if (result==null)
        {
            cloudDatabaseModel.updateUser(accountList.getAccountById(id));
        }
        return result;
    }

    @Override
    public String changePassword(Account oldAccount, Account newAccount) {
        if (hasId(oldAccount.getId()))
        {
            String result = accountList.getAccountById(oldAccount.getId()).changePassWord(oldAccount, newAccount);
            if (result==null)
            {
                cloudDatabaseModel.updateUser(accountList.getAccountById(oldAccount.getId()));
            }
            return result;
        }
        else
        {
            return "Can't find the Account [" + oldAccount.getId() + "]";
        }
    }

    @Override
    public String updateBasicInformation(Account oldAccount, Account newAccount) {
        System.out.println(2);
        if (hasId(oldAccount.getId()))
        {
            System.out.println(3);
            accountList.getAccountById(oldAccount.getId()).update(newAccount.getUserName(),newAccount.getBirthday());
            System.out.println(5);
            property.firePropertyChange("updateAccount",null,accountList.getAccountById(oldAccount.getId()));
            cloudDatabaseModel.updateUser(accountList.getAccountById(oldAccount.getId()));
            System.out.println(7);
            return null;
        }
        else
        {
            System.out.println(22);
            return "Can't find the Account [" + oldAccount.getId() + "]";
        }
    }

    @Override
    public String addNewFriend() {
        return null;
    }

    @Override
    public FriendList getFriendListByAccount(Account account) {
        FriendList friendList = new FriendList();
        Account targetAccount = accountList.getAccountById(account.getId());
        FriendSettingList friendSettingList = targetAccount.getFriendSettingList();
        for (int x=0;x<friendSettingList.getSize();x++)
        {
            friendList.addNewFriend(new Friend(accountList.getAccountById(friendSettingList.getFriendSettingByIndex(x).getId())));
        }
        return friendList;
    }

    @Override
    public void removeFriend(Account account, String friendId) {

    }


    @Override
    public void addListener(String propertyName, PropertyChangeListener listener) {
        property.addPropertyChangeListener(propertyName, listener);
    }

    @Override
    public void removeListener(String propertyName, PropertyChangeListener listener) {
        property.removePropertyChangeListener(propertyName, listener);
    }
}
