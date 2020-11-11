package com.example.SEP3_UserSystem.model.domain.list.userList;

import com.example.SEP3_UserSystem.model.domain.unit.user.FriendSetting;

import java.util.ArrayList;

public class FriendSettingList {
    private ArrayList<FriendSetting> FriendSettings;

    public FriendSettingList()
    {
        FriendSettings = new ArrayList<>();
    }

    public String addNewFriendSetting(FriendSetting newFriend)
    {
        if (getFriendSettingById(newFriend.getId())!=null)
        {
            return "Friend: " + newFriend.getNote() + "[" + newFriend.getId() + "] is not a new friend.";
        }
        else
        {
            FriendSettings.add(newFriend);
            return null;
        }
    }

    public int getSize()
    {
        return FriendSettings.size();
    }

    public FriendSetting getFriendSettingById(String id)
    {
        for (int x = 0; x< FriendSettings.size(); x++)
        {
            if (FriendSettings.get(x).getId().equals(id))
            {
                return FriendSettings.get(x);
            }
        }
        return null;
    }

    public FriendSetting getFriendSettingByIndex(int index)
    {
        if (index>=0&&index<FriendSettings.size())
        {
            return FriendSettings.get(index);
        }
        else
        {
            return null;
        }
    }

    public String updateFriendSetting(FriendSetting newFriendSetting)
    {
        for (int x = 0; x< FriendSettings.size(); x++)
        {
            if (FriendSettings.get(x).getId().equals(newFriendSetting.getId()))
            {
                FriendSettings.get(x).setNote(newFriendSetting.getNote());
                FriendSettings.get(x).setDisablePost(newFriendSetting.isDisablePost());
                return null;
            }
        }
        return "Can't find the friend: " + newFriendSetting.getNote() + "[" + newFriendSetting.getId() + "]";
    }

    public void removeFriendSettingById(String id)
    {
        for (int x = 0; x< FriendSettings.size(); x++)
        {
            if (FriendSettings.get(x).getId().equals(id))
            {
                FriendSettings.remove(x);
                break;
            }
        }
    }

    public FriendSettingList copy()
    {
        FriendSettingList copy = new FriendSettingList();
        for (int x = 0; x< FriendSettings.size(); x++)
        {
            copy.addNewFriendSetting(FriendSettings.get(x).copy());
        }
        return copy;
    }
}