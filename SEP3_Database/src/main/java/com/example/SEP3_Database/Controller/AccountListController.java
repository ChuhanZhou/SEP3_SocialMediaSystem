package com.example.SEP3_Database.Controller;

import com.example.SEP3_Database.model.DatabaseModel;
import com.example.SEP3_Database.model.DatabaseModelManager;
import com.example.SEP3_Database.model.domain.unit.user.Account;
import com.google.gson.Gson;
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
    public void addAccount(@RequestBody String newAccount)
    {
        System.out.println("Post");
        databaseModel.addAccount(gson.fromJson(newAccount,Account.class));
    }

    @RequestMapping(method = RequestMethod.GET)
    public String getAllAccount()
    {
        return gson.toJson(databaseModel.getAllAccount());
    }

    @RequestMapping(method = RequestMethod.PATCH)
    public void updateUser(@RequestBody String newAccount)
    {
        databaseModel.updateUser(gson.fromJson(newAccount,Account.class));
    }

    @RequestMapping(method = RequestMethod.DELETE)
    public void removeAccount(@RequestBody String account)
    {
        databaseModel.removeAccount(gson.fromJson(account,Account.class));
    }
}
