package com.example.SEP3_Database.model;

import com.example.SEP3_Database.model.domain.list.userList.AccountList;
import com.example.SEP3_Database.model.domain.unit.user.Account;

public interface DatabaseModel {
    void addAccount(Account newAccount);
    AccountList getAllAccount();
    void updateUser(Account newAccount);
    void removeAccount(Account account);
}
