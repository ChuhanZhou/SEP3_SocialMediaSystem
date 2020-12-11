package com.example.SEP3_Database.model.domain.unit.post;

import com.example.SEP3_Database.model.domain.list.postList.CommentList;
import com.example.SEP3_Database.model.domain.unit.time.MyTime;
import org.joda.time.DateTime;

import java.time.LocalDateTime;
import java.util.ArrayList;

public class Post {
    private MyTime Time;
    private String PostId;
    private String SenderId;
    private String Title;
    private String Body;
    private ArrayList<String> LikerIdList;
    private CommentList CommentList;
    private ArrayList<String> DisableList;

    public Post(String senderId, String title, String body, ArrayList<String> disableList) {
        SenderId = senderId;
        Title = title;
        Body = body;
        LikerIdList = new ArrayList<String>();
        CommentList = new CommentList();
        DisableList = new ArrayList<String>(disableList);
    }

    public Post(String postId, Post post) {
        PostId = postId;
        SenderId = post.SenderId;
        Title = post.Title;
        Body = post.Body;
        Time = new MyTime(LocalDateTime.now());
        LikerIdList = new ArrayList<>();
        CommentList = new CommentList();
        DisableList = new ArrayList<>(post.DisableList);
    }

    public Post(Post post) {
        PostId = post.PostId;
        SenderId = post.SenderId;
        Title = post.Title;
        Body = post.Body;
        Time = post.Time.copy();
        LikerIdList = new ArrayList<>(post.LikerIdList);
        CommentList = post.CommentList.copy();
        DisableList = new ArrayList<>(post.DisableList);
    }

    public String getTitle() {
        return Title;
    }

    public void setTitle(String title) {
        Title = title;
    }

    public MyTime getTime() {
        return Time;
    }

    public void setTime(MyTime time) {
        Time = time;
    }

    public String getSenderId() {
        return SenderId;
    }

    public void setSenderId(String senderId) {
        SenderId = senderId;
    }

    public String getBody() {
        return Body;
    }

    public void setBody(String body) {
        Body = body;
    }

    public String getPostId() {
        return PostId;
    }

    public void setPostId(String postId) {
        PostId = postId;
    }

    public CommentList getCommentList() {
        return CommentList;
    }

    public void setCommentList(CommentList commentList) {
        CommentList = commentList;
    }

    public ArrayList<String> getDisableList() {
        return DisableList;
    }

    public void setDisableList(ArrayList<String> disableList) {
        DisableList = disableList;
    }

    public ArrayList<String> getLikerIdList() {
        return LikerIdList;
    }

    public void setLikerIdList(ArrayList<String> likerIdList) {
        LikerIdList = likerIdList;
    }

    public boolean isLiker(String id) {
        for (int x = 0; x < LikerIdList.size(); x++) {
            if (LikerIdList.get(x).equals(id)) {
                return true;
            }
        }
        return false;
    }

    public boolean isDisable(String id) {
        for (int x = 0; x < DisableList.size(); x++) {
            if (DisableList.get(x).equals(id)) {
                return true;
            }
        }
        return false;
    }

    public String addLiker(String id) {
        if (!isLiker(id)) {
            LikerIdList.add(id);
            return null;
        }
        return "Not a new liker.";
    }

    public String removeLiker(String id) {
        if (isLiker(id)) {
            LikerIdList.remove(id);
            return null;
        }
        return "Not a liker.";
    }

    public String updateByPost(Post post) {
        if (PostId.equals(post.PostId) && SenderId.equals(post.SenderId)) {
            Title = post.Title;
            Body = post.Body;
            DisableList = new ArrayList<>(post.DisableList);
        }
        return "Wrong update.";
    }

    public String update(Post post) {
        if (PostId.equals(post.PostId) && SenderId.equals(post.SenderId)) {
            Title = post.Title;
            Body = post.Body;
            LikerIdList = new ArrayList<>(post.LikerIdList);
            CommentList = post.CommentList;
            DisableList = new ArrayList<>(post.DisableList);
        }
        return "Wrong update.";
    }

    public Post copy() {
        return new Post(this);
    }
    public void setDateTime(DateTime dateTime)
    {
        int Y = dateTime.getYear();
        int M = dateTime.getMonthOfYear();
        int D = dateTime.getDayOfMonth();
        int H = dateTime.getHourOfDay();
        int Mi = dateTime.getMinuteOfHour();
        System.out.println(Y+"/"+M+"/"+D+"/"+H+"/"+Mi);
        Time = new MyTime(Y,M,D,H,Mi);
        //Time.setDay(D);
        //Time.setHour(H);
        //Time.setMinute(Mi);
        //Time.setMonth(M);
        //Time.setYear(Y);
    }
}
