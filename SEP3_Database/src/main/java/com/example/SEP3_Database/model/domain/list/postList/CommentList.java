package com.example.SEP3_Database.model.domain.list.postList;

import com.example.SEP3_Database.model.domain.unit.post.Comment;

import java.util.ArrayList;

public class CommentList {
    private ArrayList<Comment> Comments;

    public CommentList()
    {
        Comments = new ArrayList<Comment>();
    }

    public CommentList(ArrayList<Comment> commentList)
    {
        Comments = new ArrayList<Comment>();
        for (int x=0;x<commentList.size();x++)
        {
            Comments.add(commentList.get(x).copy());
        }
    }

    public boolean hasCommentId(String id)
    {
        for (int x=0;x<Comments.size();x++)
        {
            if (Comments.get(x).getCommentId()==id)
            {
                return true;
            }
        }
        return false;
    }

    public String addComment(Comment comment)
    {
        if (comment!=null)
        {
            if (!hasCommentId(comment.getCommentId()))
            {
                Comments.add(comment);
            }
            else
            {
                return "Not a new comment.";
            }
        }
        return "Input null.";
    }

    public Comment getCommentByCommentId(String id)
    {
        for (int x=0;x<Comments.size();x++)
        {
            if (Comments.get(x).getCommentId()==id)
            {
                return Comments.get(x);
            }
        }
        return null;
    }

    public Comment getCommentByIndex(int index)
    {
        if (index>=0&&index<Comments.size())
        {
            return Comments.get(index);
        }

        return null;
    }

    public void removeCommentByCommentId(String id)
    {
        for (int x=0;x<Comments.size();x++)
        {
            if (Comments.get(x).getCommentId()==id)
            {
                Comments.remove(x);
                break;
            }
        }
    }

    public CommentList copy()
    {
        return new CommentList(Comments);
    }
}
