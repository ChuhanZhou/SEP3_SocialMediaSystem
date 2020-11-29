package com.example.SEP3_Database.controller;

import com.example.SEP3_Database.model.DatabaseModel;
import com.example.SEP3_Database.model.DatabaseModelManager;
import com.example.SEP3_Database.model.domain.unit.user.Account;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/api/account")
public class AccountListController {
    private DatabaseModel databaseModel;
    private Gson gson;

    public AccountListController()
    {
        databaseModel = DatabaseModelManager.getModelManager();
        gson = new Gson();
    }

    @RequestMapping(method = RequestMethod.POST)
    public String addAccount(@RequestBody String newAccount)
    {
        System.out.println("Post:" + newAccount);
        Account account = gson.fromJson(newAccount,Account.class);
        databaseModel.addAccount(account);
        return newAccount;
    }

    @RequestMapping(method = RequestMethod.GET)
    public String getAllAccount()
    {
        return gson.toJson(databaseModel.getAllAccount());
    }

    @RequestMapping(method = RequestMethod.PUT)
    public String updateUser(@RequestBody String newAccount)
    {
        System.out.println("Put:" + newAccount);
        Account account = gson.fromJson(newAccount,Account.class);
        databaseModel.updateUser(account);
        return newAccount;
    }

    @RequestMapping(method = RequestMethod.DELETE)
    public void removeAccount(@RequestBody String account)
    {
        System.out.println("Delete:" + account);
        Account removeAccount = gson.fromJson(account,Account.class);
        databaseModel.removeAccount(removeAccount);
    }
}
