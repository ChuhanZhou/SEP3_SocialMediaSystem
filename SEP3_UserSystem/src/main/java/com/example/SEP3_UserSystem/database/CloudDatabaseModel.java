package com.example.SEP3_UserSystem.database;

import com.example.SEP3_UserSystem.model.domain.unit.user.Account;
import com.example.SEP3_UserSystem.model.domain.list.userList.AccountList;

public interface CloudDatabaseModel {
    void addAccount(Account newAccount);
    AccountList getAllAccount();
    void updateUser(Account newAccount);
    void removeAccount(Account account);
}
