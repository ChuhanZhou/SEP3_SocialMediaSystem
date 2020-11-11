package com.example.SEP3_Database.model;

import com.example.SEP3_Database.model.domain.list.userList.AccountList;
import com.example.SEP3_Database.persistence.DataFileContext;
import com.example.SEP3_Database.model.domain.unit.user.Account;

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
        AccountList accountList = DataFileContext.readAccountListData();
        if (accountList!=null)
        {
            accountList.addNewAccount(newAccount);
            DataFileContext.updateAccountListData(accountList);
        }
    }

    @Override
    public AccountList getAllAccount() {
        return DataFileContext.readAccountListData();
    }

    @Override
    public void updateUser(Account newAccount) {
        AccountList accountList = DataFileContext.readAccountListData();
        if (accountList!=null)
        {
            accountList.updateAccount(newAccount);
            DataFileContext.updateAccountListData(accountList);
        }
    }

    @Override
    public void removeAccount(Account account) {
        AccountList accountList = DataFileContext.readAccountListData();
        if (accountList!=null)
        {
            accountList.removeAccountById(account.getId());
            DataFileContext.updateAccountListData(accountList);
        }
    }
}
