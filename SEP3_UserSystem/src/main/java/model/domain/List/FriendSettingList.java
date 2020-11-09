package model.domain.List;

import model.domain.User.FriendSetting;

import java.util.ArrayList;

public class FriendSettingList {
    private ArrayList<FriendSetting> FriendSettingList;

    public FriendSettingList()
    {
        FriendSettingList = new ArrayList<>();
    }

    public String addNewFriendSetting(FriendSetting newFriend)
    {
        if (getFriendSettingById(newFriend.getId())!=null)
        {
            return "Friend: " + newFriend.getNote() + "[" + newFriend.getId() + "] is not a new friend.";
        }
        else
        {
            FriendSettingList.add(newFriend);
            return null;
        }
    }

    public FriendSetting getFriendSettingById(String id)
    {
        for (int x=0;x<FriendSettingList.size();x++)
        {
            if (FriendSettingList.get(x).getId().equals(id))
            {
                return FriendSettingList.get(x).copy();
            }
        }
        return null;
    }

    public String updateFriendSetting(FriendSetting newFriendSetting)
    {
        for (int x=0;x<FriendSettingList.size();x++)
        {
            if (FriendSettingList.get(x).getId().equals(newFriendSetting.getId()))
            {
                FriendSettingList.get(x).setNote(newFriendSetting.getNote());
                FriendSettingList.get(x).setDisablePost(newFriendSetting.isDisablePost());
                return null;
            }
        }
        return "Can't find the friend: " + newFriendSetting.getNote() + "[" + newFriendSetting.getId() + "]";
    }

    public void removeFriendSettingById(String id)
    {
        for (int x=0;x<FriendSettingList.size();x++)
        {
            if (FriendSettingList.get(x).getId().equals(id))
            {
                FriendSettingList.remove(x);
                break;
            }
        }
    }

    public FriendSettingList copy()
    {
        FriendSettingList copy = new FriendSettingList();
        for (int x=0;x<FriendSettingList.size();x++)
        {
            copy.addNewFriendSetting(FriendSettingList.get(x).copy());
        }
        return copy;
    }
}
