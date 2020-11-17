package com.example.SEP3_Database.model;

import com.example.SEP3_Database.jdbc.JDBC_interface;
import com.example.SEP3_Database.jdbc.Jdbc_User;
import com.example.SEP3_Database.model.domain.list.userList.AccountList;
import com.example.SEP3_Database.persistence.DataFileContext;
import com.example.SEP3_Database.model.domain.unit.user.Account;

import java.util.ArrayList;

public class DatabaseModelManager implements DatabaseModel{
    private static DatabaseModelManager modelManager;
    private boolean databaseOnline;
    private JDBC_interface jdbc;

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
        jdbc = new Jdbc_User();
        databaseOnline = false;
        if (jdbc.init())
        {
            databaseOnline = true;
            jdbc.CreateDataBase();
            System.out.println("Connect to the Database.");
        }
    }

    @Override
    public void addAccount(Account newAccount) {
        AccountList accountList = DataFileContext.readAccountListData();
        if (accountList!=null)
        {
            if (databaseOnline)
            {
                jdbc.insertUserInTable(newAccount);
            }
            accountList.addNewAccount(newAccount);
            DataFileContext.updateAccountListData(accountList);
        }
    }

    @Override
    public AccountList getAllAccount() {
        if (databaseOnline)
        {
            ArrayList<Account> list = jdbc.getAccountList();
            AccountList accountList = new AccountList();
            for (int x=0;x<list.size();x++)
            {
                accountList.addNewAccount(list.get(x));
            }
            return accountList;
        }
        else
        {
            return DataFileContext.readAccountListData();
        }
    }

    @Override
    public void updateUser(Account newAccount) {
        AccountList accountList = DataFileContext.readAccountListData();
        if (accountList!=null)
        {
            if (databaseOnline)
            {
                jdbc.UpdateDataBaseInUserTable(newAccount);
            }
            accountList.updateAccount(newAccount);
            accountList.changePassword(newAccount);
            DataFileContext.updateAccountListData(accountList);
        }
    }

    @Override
    public void removeAccount(Account account) {
        AccountList accountList = DataFileContext.readAccountListData();
        if (accountList!=null)
        {
            if (databaseOnline)
            {
                //数据库方法：删除数据
            }
            accountList.removeAccountById(account.getId());
            DataFileContext.updateAccountListData(accountList);
        }
    }
}
