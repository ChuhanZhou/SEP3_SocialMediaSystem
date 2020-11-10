package model.domain;

import model.domain.list.userList.AccountList;
import model.domain.unit.user.Account;

public class DatabaseModelManager implements DatabaseModel{
    private static DatabaseModelManager modelManager;

    public static DatabaseModel getModelManager()
    {
        if (modelManager == null)
        {
            modelManager = new DatabaseModelManager();
        }
        return modelManager;
    }

    public DatabaseModelManager()
    {
        
    }

    @Override
    public void addAccount(Account newAccount) {

    }

    @Override
    public AccountList getAllAccount() {
        return null;
    }

    @Override
    public void updateUser(Account newAccount) {

    }

    @Override
    public void removeAccount(Account account) {

    }
}
