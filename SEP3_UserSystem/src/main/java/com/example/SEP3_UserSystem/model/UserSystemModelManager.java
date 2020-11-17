package com.example.SEP3_UserSystem.model;

import com.example.SEP3_UserSystem.model.domain.list.userList.FriendSettingList;
import com.example.SEP3_UserSystem.model.domain.unit.user.*;
import com.example.SEP3_UserSystem.database.CloudDatabaseModel;
import com.example.SEP3_UserSystem.database.CloudDatabaseModelManager;
import com.example.SEP3_UserSystem.model.domain.list.userList.AccountList;
import com.example.SEP3_UserSystem.model.domain.list.userList.FriendList;

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
                if (!targetAccount.getUserStatus().isOnline())
                {
                    targetAccount.getUserStatus().login();
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
        targetAccount.getUserStatus().logoff();
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
        if (hasId(oldAccount.getId()))
        {
            accountList.getAccountById(oldAccount.getId()).update(((BasicInformation) newAccount));
            property.firePropertyChange("updateAccount",null,accountList.getAccountById(oldAccount.getId()));
            cloudDatabaseModel.updateUser(accountList.getAccountById(oldAccount.getId()));
            return null;
        }
        else
        {
            return "Can't find the Account [" + oldAccount.getId() + "]";
        }
    }

    @Override
    public String updateFriendSetting(String id,FriendSetting newFriendSetting) {
        if (!id.equals(newFriendSetting.getId()))
        {
            if (newFriendSetting.getStatus()==FriendSettingStatus.AGREE)
            {
                String result = accountList.getAccountById(id).getFriendSettingList().updateFriendSetting(newFriendSetting);
                property.firePropertyChange("updateFriendSetting",null,id);
                cloudDatabaseModel.updateUser(accountList.getAccountById(id));
                return result;
            }
            else
            {
                return "Wrong status.";
            }
        }
        else
        {
            return "You can't write your own Id";
        }
    }

    @Override
    public String addNewFriend(String id,FriendSetting friendSetting) {
        if (!id.equals(friendSetting.getId()))
        {
            String friendId = friendSetting.getId();
            Account account = accountList.getAccountById(id);
            if (friendSetting.waitAgree())
            {
                //System.out.println(222222);
                if (hasId(friendId))
                {
                    account.getFriendSettingList().addNewFriendSetting(friendSetting);
                    property.firePropertyChange("updateFriendSetting",null,id);
                    cloudDatabaseModel.updateUser(accountList.getAccountById(id));
                    accountList.getAccountById(friendId).getFriendSettingList().addNewFriendSetting(new FriendSetting(id));
                    property.firePropertyChange("updateFriendSetting",null,friendId);
                    cloudDatabaseModel.updateUser(accountList.getAccountById(friendId));
                    return null;
                }
                else
                {
                    return "Wrong Id";
                }
            }
            else if (friendSetting.isConfirmed())
            {
                //System.out.println(3232323);
                if (hasId(friendId))
                {
                    //System.out.println(11111111);
                    account.getFriendSettingList().getFriendSettingFromUnconfirmedById(friendId).update(friendSetting);
                    System.out.println(account.getFriendSettingList().getFriendSettingFromAgreeById(friendId).getStatus());
                    property.firePropertyChange("updateFriendSetting",null,id);
                    cloudDatabaseModel.updateUser(accountList.getAccountById(id));
                    if (friendSetting.getStatus()== FriendSettingStatus.AGREE)
                    {
                        accountList.getAccountById(friendId).getFriendSettingList().getFriendSettingFromUnconfirmedById(id).setStatus(true);
                    }
                    else
                    {
                        accountList.getAccountById(friendId).getFriendSettingList().getFriendSettingFromUnconfirmedById(id).setStatus(false);
                    }
                    property.firePropertyChange("updateFriendSetting",null,friendId);
                    cloudDatabaseModel.updateUser(accountList.getAccountById(friendId));
                    return null;
                }
                else
                {
                    return "Wrong Id";
                }
            }
            else
            {
                return "Wrong status.";
            }
        }
        else
        {
            return "You can't write your own Id";
        }

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
    public void removeFriend(String id, String friendId) {
        accountList.getAccountById(id).getFriendSettingList().getFriendSettingFromAgreeById(friendId).delete();
        property.firePropertyChange("updateFriendSetting",null,id);
        cloudDatabaseModel.updateUser(accountList.getAccountById(id));
        accountList.getAccountById(friendId).getFriendSettingList().getFriendSettingFromAgreeById(id).delete();
        property.firePropertyChange("updateFriendSetting",null,friendId);
        cloudDatabaseModel.updateUser(accountList.getAccountById(friendId));
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
