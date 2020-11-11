package com.example.SEP3_Database.model.domain.unit.user;

public class FriendSetting extends User {
    private String Note;
    private boolean DisablePost;

    public FriendSetting(String id,boolean disablePost)
    {
        super(id);
        DisablePost = disablePost;
    }

    private FriendSetting(String id,boolean disablePost,String note)
    {
        this(id,disablePost);
        Note = note;
    }

    public String getNote() {
        return Note;
    }

    public boolean isDisablePost() {
        return DisablePost;
    }

    public void setNote(String note) {
        Note = note;
    }

    public void setDisablePost(boolean disablePost) {
        DisablePost = disablePost;
    }

    public void update(FriendSetting friendSetting) {
        Note = friendSetting.getNote();
        DisablePost = friendSetting.isDisablePost();
    }

    public FriendSetting copy() {
        return new FriendSetting(getId(),DisablePost,Note);
    }
}
