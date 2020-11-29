package com.example.SEP3_Database.controller;

import com.example.SEP3_Database.model.DatabaseModel;
import com.example.SEP3_Database.model.DatabaseModelManager;
import com.example.SEP3_Database.model.domain.unit.message.PrivateMessage;
import com.google.gson.Gson;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/api/privateMessage")
public class PrivateMessageListController {
    private DatabaseModel databaseModel;
    private Gson gson;

    public PrivateMessageListController()
    {
        databaseModel = DatabaseModelManager.getModelManager();
        gson = new Gson();
    }

    @RequestMapping(method = RequestMethod.POST)
    public String addPrivateMessage(@RequestBody String newPrivateMessage)
    {
        System.out.println("Post:" + newPrivateMessage);
        PrivateMessage groupMessage = gson.fromJson(newPrivateMessage,PrivateMessage.class);
        databaseModel.addPrivateMessage(groupMessage);
        return newPrivateMessage;
    }

    @RequestMapping(method = RequestMethod.GET)
    public String getAllPrivateMessage()
    {
        return gson.toJson(databaseModel.getAllPrivateMessage());
    }
}
