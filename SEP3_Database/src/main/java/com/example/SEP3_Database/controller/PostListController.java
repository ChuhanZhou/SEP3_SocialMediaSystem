package com.example.SEP3_Database.controller;

import com.example.SEP3_Database.model.DatabaseModel;
import com.example.SEP3_Database.model.DatabaseModelManager;
import com.example.SEP3_Database.model.domain.unit.post.Post;
import com.google.gson.Gson;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/api/post")
public class PostListController {
    private DatabaseModel databaseModel;
    private Gson gson;

    public PostListController()
    {
        databaseModel = DatabaseModelManager.getModelManager();
        gson = new Gson();
    }

    @RequestMapping(method = RequestMethod.POST)
    public String addPost(@RequestBody String newPost)
    {
        System.out.println("Post:" + newPost);
        Post post = gson.fromJson(newPost,Post.class);
        databaseModel.addPost(post);
        return newPost;
    }

    @RequestMapping(method = RequestMethod.GET)
    public String getAllPost()
    {
        System.out.println("Get:" + gson.toJson(databaseModel.getAllPost()));
        return gson.toJson(databaseModel.getAllPost());
    }

    @RequestMapping(method = RequestMethod.PUT)
    public String updateUser(@RequestBody String newPost)
    {
        System.out.println("Put:" + newPost);
        Post post = gson.fromJson(newPost,Post.class);
        databaseModel.updatePost(post);
        return newPost;
    }

    @RequestMapping(method = RequestMethod.DELETE)
    public void removePost(@RequestParam String postId)
    {
        System.out.println("Delete:" + postId);
        databaseModel.removePost(postId);
    }
}
