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
        System.out.println(12312);
    }

    @PostMapping
    public void addAccount(@RequestBody Account newAccount)
    {
        databaseModel.addAccount(newAccount);
    }

    @RequestMapping(method = RequestMethod.GET)
    @ResponseBody
    public String getAllAccount()
    {
        System.out.println("Get");
        return gson.toJson(databaseModel.getAllAccount());
    }

    @PatchMapping
    public void updateUser(@RequestBody Account newAccount)
    {
        databaseModel.updateUser(newAccount);
    }

    @DeleteMapping
    public void removeAccount(@RequestBody Account account)
    {
        databaseModel.removeAccount(account);
    }
}
