package model;

import model.domain.list.userList.AccountList;

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



    @Override
    public void addListener(String propertyName, PropertyChangeListener listener) {
        property.addPropertyChangeListener(propertyName, listener);
    }

    @Override
    public void removeListener(String propertyName, PropertyChangeListener listener) {
        property.removePropertyChangeListener(propertyName, listener);
    }
}
