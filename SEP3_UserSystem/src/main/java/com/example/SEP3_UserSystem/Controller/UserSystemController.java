package com.example.SEP3_UserSystem.Controller;

import com.example.SEP3_UserSystem.model.UserSystemModel;
import com.example.SEP3_UserSystem.model.UserSystemModelManager;
import com.google.gson.Gson;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/api")
public class UserSystemController {
    public UserSystemModel userSystemModel;
    private Gson gson;

    public UserSystemController()
    {
        userSystemModel = UserSystemModelManager.getModelManager();
        gson = new Gson();
    }

    @GetMapping("/friend")
    public String getFriendList(@RequestParam String userId)
    {
        if (userSystemModel.hasId(userId))
        {
            return gson.toJson(userSystemModel.getFriendListByAccount(userSystemModel.getAccountById(userId)));
        }
        return null;
    }

    @GetMapping("/hasUser")
    public boolean hasUser(@RequestParam String userId)
    {
        return userSystemModel.hasId(userId);
    }
}
