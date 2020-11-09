package model.domain.List.UserList;

import model.domain.Unit.User.Friend;

import java.util.ArrayList;

public class FriendList {
    private ArrayList<Friend> Friends;

    public FriendList()
    {
        Friends = new ArrayList<>();
    }

    public String addNewFriend(Friend newFriend)
    {
        if (getFriendById(newFriend.getId())!=null)
        {
            return "Friend [" + newFriend.getId() + "] is not a new friend.";
        }
        Friends.add(newFriend);
        return null;
    }

    public Friend getFriendById(String id)
    {
        for (int x = 0; x< Friends.size(); x++)
        {
            if (Friends.get(x).getId().equals(id))
            {
                return Friends.get(x).copy();
            }
        }
        return null;
    }

    public String updateFriend(Friend account)
    {
        for (int x = 0; x< Friends.size(); x++)
        {
            if (Friends.get(x).getId().equals(account.getId()))
            {
                Friends.get(x).update(account);
                return null;
            }
        }
        return "Can't find friend [" + account.getId() + "].";
    }

    public void removeFriendById(String id)
    {
        for (int x = 0; x< Friends.size(); x++)
        {
            if (Friends.get(x).getId().equals(id))
            {
                Friends.remove(x);
                break;
            }
        }
    }

    public FriendList copy()
    {
        FriendList copy = new FriendList();
        for (int x = 0; x< Friends.size(); x++)
        {
            copy.addNewFriend(Friends.get(x).copy());
        }
        return copy;
    }
}
