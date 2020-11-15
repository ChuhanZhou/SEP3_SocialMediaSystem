package com.example.SEP3_Database.model.domain.unit.user;

public class FriendSetting extends User {
    private String Note;
    private boolean DisablePost;
    private FriendSettingStatus Status;

    public FriendSetting(String id,String note,boolean disablePost)
    {
        super(id);
        if (note==null)
        {
            Note = "";
        }
        else
        {
            Note = note;
        }
        DisablePost = disablePost;
        Status = FriendSettingStatus.UNCONFIRMED;
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
        Status = FriendSettingStatus.UNCONFIRMED;
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
        if (Status == FriendSettingStatus.UNCONFIRMED)
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
        if (Status== FriendSettingStatus.UNCONFIRMED&&Note==null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public Boolean isConfirmed()
    {
        if (Status== FriendSettingStatus.AGREE||Status== FriendSettingStatus.DISAGREE)
        {
            return true;
        }
        else
        {
            return false;
        }
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
