package com.example.SEP3_Database.model.domain.unit.post;

public class Comment {
    private String CommentId;
    private String SenderId;
    private String CommentBody;

    public Comment(String senderId,String commentBody)
    {
        SenderId = senderId;
        CommentBody = commentBody;
    }

    public Comment(String commentId, Comment comment)
    {
        CommentId = commentId;
        SenderId = comment.SenderId;
        CommentBody = comment.CommentBody;
    }

    public String getCommentId() {
        return CommentId;
    }

    public void setCommentId(String commentId) {
        CommentId = commentId;
    }

    public String getSenderId() {
        return SenderId;
    }

    public void setSenderId(String senderId) {
        SenderId = senderId;
    }

    public String getCommentBody() {
        return CommentBody;
    }

    public void setCommentBody(String commentBody) {
        CommentBody = commentBody;
    }

    public Comment copy()
    {
        return new Comment(CommentId,this);
    }
}
