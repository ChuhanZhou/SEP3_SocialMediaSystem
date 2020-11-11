package model.domain;

import model.domain.list.userList.AccountList;
import model.domain.unit.user.Account;

public interface DatabaseModel {
    void addAccount(Account newAccount);
    AccountList getAllAccount();
    void updateUser(Account newAccount);
    void removeAccount(Account account);
}
