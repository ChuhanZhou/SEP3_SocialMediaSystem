package model;

import model.domain.list.userList.AccountList;
import model.domain.list.userList.FriendList;
import model.domain.unit.user.Account;

import java.beans.PropertyChangeListener;
import java.beans.PropertyChangeSupport;

public class UserSystemModelManager implements UserSystemModel
{
    private AccountList accountList;
    private PropertyChangeSupport property;

    public UserSystemModelManager()
    {
        property = new PropertyChangeSupport(this);
        accountList = new AccountList();
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
        return newAccount;
    }

    @Override
    public String login(String id, String password) {
        return null;
    }

    @Override
    public void logoff(String id) {

    }

    @Override
    public Account getAccountById(String id) {
        return null;
    }

    @Override
    public Account getAccountByIdAndPassword(String id, String password) {
        return null;
    }

    @Override
    public boolean hasId(String id) {
        return false;
    }

    @Override
    public String changePassword(String id, String oldPassword, String newPassword) {
        return null;
    }

    @Override
    public String changePassword(Account oldAccount, Account newAccount) {
        return null;
    }

    @Override
    public String updateBasicInformation(Account oldAccount, Account newAccount) {
        return null;
    }

    @Override
    public String addNewFriend() {
        return null;
    }

    @Override
    public FriendList getFriendListByAccount(Account account) {
        return null;
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
