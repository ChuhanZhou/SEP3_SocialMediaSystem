package database;

import model.domain.list.userList.AccountList;
import model.domain.unit.user.Account;

public interface CloudDatabase {
    void addUser(Account newAccount);
    AccountList getAllAccount();
    void updateUser(Account newAccount);
}
