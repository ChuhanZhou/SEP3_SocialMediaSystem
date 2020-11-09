package model.domain.list.userList;

import model.domain.unit.user.Account;

import java.util.ArrayList;

public class AccountList {
    private ArrayList<Account> Accounts;

    public AccountList()
    {
        Accounts = new ArrayList<>();
    }

    public String addNewAccount(Account newAccount)
    {
        if (getAccountById(newAccount.getId())!=null)
        {
            return "Account [" + newAccount.getId() + "] is not a new account.";
        }
        Accounts.add(newAccount);
        return null;
    }

    public Account getAccountById(String id)
    {
        for (int x = 0; x< Accounts.size(); x++)
        {
            if (Accounts.get(x).getId().equals(id))
            {
                return Accounts.get(x).copy();
            }
        }
        return null;
    }

    public String changePassword(String id,String oldPassword,String newPassword)
    {
        for (int x = 0; x< Accounts.size(); x++)
        {
            if (Accounts.get(x).getId().equals(id))
            {
                return Accounts.get(x).changePassWord(oldPassword, newPassword);
            }
        }
        return "Can't find user [" + id + "].";
    }

    public String updateAccount(Account account)
    {
        for (int x = 0; x< Accounts.size(); x++)
        {
            if (Accounts.get(x).getId().equals(account.getId()))
            {
                Accounts.get(x).update(account);
                return null;
            }
        }
        return "Can't find account [" + account.getId() + "].";
    }

    public void removeAccountById(String id)
    {
        for (int x = 0; x< Accounts.size(); x++)
        {
            if (Accounts.get(x).getId().equals(id))
            {
                Accounts.remove(x);
                break;
            }
        }
    }

    public AccountList copy()
    {
        AccountList copy = new AccountList();
        for (int x = 0; x< Accounts.size(); x++)
        {
            copy.addNewAccount(Accounts.get(x).copy());
        }
        return copy;
    }
}
