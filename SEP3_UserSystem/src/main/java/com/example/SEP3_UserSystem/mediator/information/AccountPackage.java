package com.example.SEP3_UserSystem.mediator.information;

import com.example.SEP3_UserSystem.model.domain.list.userList.AccountList;
import com.example.SEP3_UserSystem.model.domain.unit.user.Account;

public class AccountPackage extends InformationPackage
{
    private AccountList SendList;

    public AccountPackage(AccountList accountList,String keyword)
    {
        super(InformationType.ACCOUNT,keyword);
        SendList = accountList.copy();
    }

    public AccountPackage(Account account, String keyword)
    {
        super(InformationType.ACCOUNT,keyword);
        SendList = new AccountList();
        SendList.addNewAccount(account);
    }

    public AccountList getSendList() {
        return SendList;
    }
}
