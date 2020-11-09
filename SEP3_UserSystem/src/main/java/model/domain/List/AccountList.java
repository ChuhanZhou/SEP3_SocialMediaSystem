package model.domain.List;

import model.domain.User.Account;

import java.util.ArrayList;

public class AccountList {
    private ArrayList<Account> AccountList;

    public AccountList()
    {
        AccountList = new ArrayList<>();
    }

    public String addNewAccount(Account newAccount)
    {
        if (getAccountById(newAccount.getId())!=null)
        {
            return "Account [" + newAccount.getId() + "] is not a new account.";
        }
        AccountList.add(newAccount);
        return null;
    }

    public Account getAccountById(String id)
    {
        for (int x=0;x<AccountList.size();x++)
        {
            if (AccountList.get(x).getId().equals(id))
            {
                return AccountList.get(x).copy();
            }
        }
        return null;
    }

    public String changePassword(String id,String oldPassword,String newPassword)
    {
        for (int x=0;x<AccountList.size();x++)
        {
            if (AccountList.get(x).getId().equals(id))
            {
                return AccountList.get(x).changePassWord(oldPassword, newPassword);
            }
        }
        return "Can't find user [" + id + "].";
    }

    public String updateAccount(Account account)
    {
        for (int x=0;x<AccountList.size();x++)
        {
            if (AccountList.get(x).getId().equals(account.getId()))
            {
                AccountList.get(x).update(account);
                return null;
            }
        }
        return "Can't find account [" + account.getId() + "].";
    }

    public void removeAccountById(String id)
    {
        for (int x=0;x<AccountList.size();x++)
        {
            if (AccountList.get(x).getId().equals(id))
            {
                AccountList.remove(x);
                break;
            }
        }
    }
}
