package com.example.SEP3_Database.model.domain.list.userList;

import com.example.SEP3_Database.model.domain.unit.user.FriendSetting;
import com.example.SEP3_Database.model.domain.unit.user.FriendSettingStatus;

import java.util.ArrayList;

public class FriendSettingList {
    private ArrayList<FriendSetting> FriendSettings;

    public FriendSettingList()
    {
        FriendSettings = new ArrayList<>();
    }

    public String addNewFriendSetting(FriendSetting newFriend)
    {
        if (getFriendSettingFromAgreeById(newFriend.getId())!=null)
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

    public FriendSetting getFriendSettingFromAgreeById(String id)
    {
        FriendSettingList agreeList = getFriendSettingListByStatus(FriendSettingStatus.AGREE);
        for (int x=0;x<agreeList.getSize();x++)
        {
            if (agreeList.getFriendSettingByIndex(x).getId().equals(id))
            {
                return agreeList.getFriendSettingByIndex(x);
            }
        }
        return null;
    }

    public FriendSetting getFriendSettingFromUnconfirmedById(String id)
    {
        FriendSettingList agreeList = getFriendSettingListByStatus(FriendSettingStatus.UNCONFIRMED);
        for (int x=0;x<agreeList.getSize();x++)
        {
            if (agreeList.getFriendSettingByIndex(x).getId().equals(id))
            {
                return agreeList.getFriendSettingByIndex(x);
            }
        }
        return null;
    }

    public FriendSettingList getFriendSettingListById(String id)
    {
        FriendSettingList friendSettingList = new FriendSettingList();
        for (int x=0;x<FriendSettings.size();x++)
        {
            if (FriendSettings.get(x).getId().equals(id))
            {
                friendSettingList.FriendSettings.add(FriendSettings.get(x));
            }
        }
        return friendSettingList;
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

    public FriendSettingList getFriendSettingListByStatus(FriendSettingStatus status)
    {
        FriendSettingList searchList = new FriendSettingList();
        for (int x=0;x<FriendSettings.size();x++)
        {
            if (FriendSettings.get(x).getStatus().equals(status))
            {
                searchList.FriendSettings.add(FriendSettings.get(x));
            }
        }
        return searchList;
    }

    public ArrayList<FriendSetting> getFriendSettingList()
    {
        ArrayList<FriendSetting> copy = new ArrayList();
        for (int x=0;x<FriendSettings.size();x++)
        {
            copy.add(FriendSettings.get(x).copy());
        }
        return copy;
    }

    public String updateFriendSetting(FriendSetting newFriendSetting)
    {
        for (int x = 0; x< FriendSettings.size(); x++)
        {
            if (FriendSettings.get(x).getStatus()==FriendSettingStatus.AGREE)
            {
                if (FriendSettings.get(x).getId().equals(newFriendSetting.getId()))
                {
                    FriendSettings.get(x).setNote(newFriendSetting.getNote());
                    FriendSettings.get(x).setDisablePost(newFriendSetting.isDisablePost());
                    return null;
                }
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
            copy.FriendSettings.add(FriendSettings.get(x).copy());
        }
        return copy;
    }
}
