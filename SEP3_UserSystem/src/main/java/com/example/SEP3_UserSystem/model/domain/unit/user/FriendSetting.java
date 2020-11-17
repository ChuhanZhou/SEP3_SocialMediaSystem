package com.example.SEP3_UserSystem.model.domain.unit.user;

public class FriendSetting extends User {
    private String Note;
    private boolean DisablePost;
    private FriendSettingStatus Status;

    public FriendSetting(String id,String note,boolean disablePost)
    {
        super(id);
        Note = note;
        DisablePost = disablePost;
        Status = FriendSettingStatus.WAITAGREE;
    }

    private FriendSetting(String id, String note, boolean disablePost, FriendSettingStatus status)
    {
        this(id,note,disablePost);
        Status = status;
    }

    public FriendSetting(String id)
    {
        super(id);
        Note = null;
        DisablePost = false;
        Status = FriendSettingStatus.NEEDAGREE;
    }

    public boolean unconfirmed()
    {
        return Status==FriendSettingStatus.WAITAGREE||Status==FriendSettingStatus.NEEDAGREE;
    }

    public String getNote() {
        return Note;
    }

    public boolean isDisablePost() {
        return DisablePost;
    }

    public FriendSettingStatus getStatus() {
        return Status;
    }

    public void setNote(String note) {
        Note = note;
    }

    public void setDisablePost(boolean disablePost) {
        DisablePost = disablePost;
    }

    public void setStatus(boolean agree) {
        if (unconfirmed())
        {
            if (agree)
            {
                Status = FriendSettingStatus.AGREE;
            }
            else
            {
                Status = FriendSettingStatus.DISAGREE;
            }
        }
    }

    public Boolean needAgree()
    {
        return Status== FriendSettingStatus.NEEDAGREE;
    }

    public boolean waitAgree()
    {
        return Status== FriendSettingStatus.WAITAGREE;
    }

    public Boolean isConfirmed()
    {
        return Status== FriendSettingStatus.AGREE||Status== FriendSettingStatus.DISAGREE;
    }

    public void delete()
    {
        Status = FriendSettingStatus.DELETE;
    }

    public void update(FriendSetting friendSetting) {
        Note = friendSetting.getNote();
        DisablePost = friendSetting.isDisablePost();
        Status = friendSetting.getStatus();
    }

    public FriendSetting copy() {
        return new FriendSetting(getId(),Note,DisablePost, Status);
    }
}
