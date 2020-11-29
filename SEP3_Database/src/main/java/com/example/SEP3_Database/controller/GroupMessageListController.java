package com.example.SEP3_Database.controller;

import com.example.SEP3_Database.model.DatabaseModel;
import com.example.SEP3_Database.model.DatabaseModelManager;
import com.example.SEP3_Database.model.domain.unit.group.ChatGroup;
import com.example.SEP3_Database.model.domain.unit.message.GroupMessage;
import com.google.gson.Gson;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/api/groupMessage")
public class GroupMessageListController {
    private DatabaseModel databaseModel;
    private Gson gson;

    public GroupMessageListController()
    {
        databaseModel = DatabaseModelManager.getModelManager();
        gson = new Gson();
    }

    @RequestMapping(method = RequestMethod.POST)
    public String addGroupMessage(@RequestBody String newGroupMessage)
    {
        System.out.println("Post:" + newGroupMessage);
        GroupMessage groupMessage = gson.fromJson(newGroupMessage,GroupMessage.class);
        databaseModel.addGroupMessage(groupMessage);
        return newGroupMessage;
    }

    @RequestMapping(method = RequestMethod.GET)
    public String getAllGroupMessage()
    {
        return gson.toJson(databaseModel.getAllGroupMessage());
    }
}
