package com.example.SEP3_Database.controller;

import com.example.SEP3_Database.model.DatabaseModel;
import com.example.SEP3_Database.model.DatabaseModelManager;
import com.example.SEP3_Database.model.domain.unit.group.ChatGroup;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/api/chatGroup")
public class ChatGroupListController {
    private DatabaseModel databaseModel;
    private Gson gson;

    public ChatGroupListController()
    {
        databaseModel = DatabaseModelManager.getModelManager();
        gson = new Gson();
    }

    @RequestMapping(method = RequestMethod.POST)
    public String addChatGroup(@RequestBody String newChatGroup)
    {
        System.out.println("Post:" + newChatGroup);
        ChatGroup chatGroup = gson.fromJson(newChatGroup,ChatGroup.class);
        databaseModel.addChatGroup(chatGroup);
        return newChatGroup;
    }

    @RequestMapping(method = RequestMethod.GET)
    public String getAllChatGroup()
    {
        return gson.toJson(databaseModel.getAllChatGroup());
    }

    @RequestMapping(method = RequestMethod.PUT)
    public String updateUser(@RequestBody String newChatGroup)
    {
        System.out.println("Put:" + newChatGroup);
        ChatGroup chatGroup = gson.fromJson(newChatGroup,ChatGroup.class);
        databaseModel.updateChatGroup(chatGroup);
        return newChatGroup;
    }

    @RequestMapping(method = RequestMethod.DELETE)
    public void removeChatGroup(@RequestParam String chatGroupId)
    {
        System.out.println("Delete:" + chatGroupId);
        databaseModel.removeChatGroup(chatGroupId);
    }
}
