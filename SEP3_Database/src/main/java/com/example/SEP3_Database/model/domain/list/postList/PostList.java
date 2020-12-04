package com.example.SEP3_Database.model.domain.list.postList;

import com.example.SEP3_Database.model.domain.unit.post.Post;

import java.util.ArrayList;

public class PostList {
    private ArrayList<Post> Posts;

    public PostList()
    {
        Posts = new ArrayList<>();
    }

    public PostList(ArrayList<Post> postList)
    {
        Posts = new ArrayList<>();
        for (int x=0;x<postList.size();x++)
        {
            Posts.add(postList.get(x).copy());
        }
    }

    public boolean hasPostId(String id)
    {
        for (int x=0;x<Posts.size();x++)
        {
            if (Posts.get(x).getPostId()==id)
            {
                return true;
            }
        }
        return false;
    }

    public String addPost(Post post)
    {
        if (post!=null)
        {
            if (!hasPostId(post.getPostId()))
            {
                Posts.add(post);
            }
            else
            {
                return "Not a new post.";
            }
        }
        return "Input null.";
    }

    public Post getPostByPostId(String id)
    {
        for (int x=0;x<Posts.size();x++)
        {
            if (Posts.get(x).getPostId()==id)
            {
                return Posts.get(x);
            }
        }
        return null;
    }

    public Post getPostByIndex(int index)
    {
        if (index>=0&&index<Posts.size())
        {
            return Posts.get(index);
        }
        return null;
    }

    public PostList getPostBySenderId(String id)
    {
        var postList = new PostList();
        for (int x=0;x<Posts.size();x++)
        {
            if (Posts.get(x).getPostId()==id)
            {
                postList.addPost(Posts.get(x));
            }
        }
        return postList;
    }

    public String updatePost(Post post)
    {
        var target = getPostByPostId(post.getPostId());
        if (target!=null)
        {
            target = new Post(post);
            return null;
        }
        return "Not find post.";
    }

    public void removePostByPostId(String id)
    {
        for (int x=0;x<Posts.size();x++)
        {
            if (Posts.get(x).getPostId()==id)
            {
                Posts.remove(x);
                break;
            }
        }
    }

    public PostList copy()
    {
        return new PostList(Posts);
    }
}
