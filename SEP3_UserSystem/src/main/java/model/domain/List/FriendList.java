package model.domain.List;

import model.domain.User.Friend;

import java.util.ArrayList;

public class FriendList {
    private ArrayList<Friend> FriendList;

    public FriendList()
    {
        FriendList = new ArrayList<>();
    }

    public String addNewFriend(Friend newFriend)
    {
        if (getFriendById(newFriend.getId())!=null)
        {
            return "Friend [" + newFriend.getId() + "] is not a new friend.";
        }
        FriendList.add(newFriend);
        return null;
    }

    public Friend getFriendById(String id)
    {
        for (int x=0;x<FriendList.size();x++)
        {
            if (FriendList.get(x).getId().equals(id))
            {
                return FriendList.get(x).copy();
            }
        }
        return null;
    }

    public String updateFriend(Friend account)
    {
        for (int x=0;x<FriendList.size();x++)
        {
            if (FriendList.get(x).getId().equals(account.getId()))
            {
                FriendList.get(x).update(account);
                return null;
            }
        }
        return "Can't find friend [" + account.getId() + "].";
    }

    public void removeFriendById(String id)
    {
        for (int x=0;x<FriendList.size();x++)
        {
            if (FriendList.get(x).getId().equals(id))
            {
                FriendList.remove(x);
                break;
            }
        }
    }
}
