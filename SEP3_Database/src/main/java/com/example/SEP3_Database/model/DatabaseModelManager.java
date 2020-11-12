package com.example.SEP3_Database.model;

import com.example.SEP3_Database.model.domain.list.userList.AccountList;
import com.example.SEP3_Database.persistence.DataFileContext;
import com.example.SEP3_Database.model.domain.unit.user.Account;

public class DatabaseModelManager implements DatabaseModel{
    private static DatabaseModelManager modelManager;
    private boolean databaseOnline;

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
        databaseOnline = false;
        //判断能否连接数据库
        if (false)
        {
            databaseOnline = true;
        }
    }

    @Override
    public void addAccount(Account newAccount) {
        AccountList accountList = DataFileContext.readAccountListData();
        if (accountList!=null)
        {
            if (databaseOnline)
            {
                //数据库方法：添加数据
            }
            accountList.addNewAccount(newAccount);
            DataFileContext.updateAccountListData(accountList);
        }
    }

    @Override
    public AccountList getAllAccount() {
        if (databaseOnline)
        {
            //数据库方法：返回数据
        }
        else
        {
            return DataFileContext.readAccountListData();
        }
        return null;
    }

    @Override
    public void updateUser(Account newAccount) {
        AccountList accountList = DataFileContext.readAccountListData();
        if (accountList!=null)
        {
            if (databaseOnline)
            {
                //数据库方法：更新数据
            }
            accountList.updateAccount(newAccount);
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
