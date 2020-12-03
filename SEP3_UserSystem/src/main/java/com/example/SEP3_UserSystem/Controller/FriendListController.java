package com.example.SEP3_UserSystem.Controller;

import com.example.SEP3_UserSystem.model.UserSystemModel;
import com.example.SEP3_UserSystem.model.UserSystemModelManager;
import com.example.SEP3_UserSystem.model.domain.unit.user.Account;
import com.google.gson.Gson;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/api/friend")
public class FriendListController {
    public UserSystemModel userSystemModel;
    private Gson gson;

    public FriendListController()
    {
        userSystemModel = UserSystemModelManager.getModelManager();
        gson = new Gson();
    }

    @RequestMapping(method = RequestMethod.GET)
    public String getFriendList(@RequestParam String userId)
    {
        if (userSystemModel.hasId(userId))
        {
            return gson.toJson(userSystemModel.getFriendListByAccount(userSystemModel.getAccountById(userId)));
        }
        return null;
    }
}
