package com.example.SEP3_UserSystem.model.domain.unit.user;

public class FriendSetting extends User {
    private String Note;
    private boolean DisablePost;
    private FriendSettingState State;

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
        State = FriendSettingState.UNCONFIRMED;
    }

    private FriendSetting(String id,String note,boolean disablePost,FriendSettingState state)
    {
        this(id,note,disablePost);
        State = state;
    }

    public FriendSetting(String id)
    {
        super(id);
        Note = null;
        DisablePost = false;
        State = FriendSettingState.UNCONFIRMED;
    }

    public String getNote() {
        return Note;
    }

    public boolean isDisablePost() {
        return DisablePost;
    }

    public FriendSettingState getState() {
        return State;
    }

    public void setNote(String note) {
        Note = note;
    }

    public void setDisablePost(boolean disablePost) {
        DisablePost = disablePost;
    }

    public void setState(boolean agree) {
        if (State == FriendSettingState.UNCONFIRMED)
        {
            if (agree)
            {
                State = FriendSettingState.AGREE;
            }
            else
            {
                State = FriendSettingState.DISAGREE;
            }
        }
    }

    public Boolean needAgree()
    {
        if (State==FriendSettingState.UNCONFIRMED&&Note==null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public Boolean toConfirmed()
    {
        if (State==FriendSettingState.AGREE||State==FriendSettingState.DISAGREE)
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
        State = FriendSettingState.DELETE;
    }

    public void update(FriendSetting friendSetting) {
        Note = friendSetting.getNote();
        DisablePost = friendSetting.isDisablePost();
        State = friendSetting.getState();
    }

    public FriendSetting copy() {
        return new FriendSetting(getId(),Note,DisablePost, State);
    }
}
