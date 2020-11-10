using System;
using System.Collections.Generic;
using SEP3_Client.Model.Unit.User;

namespace SEP3_Client.Model.List.UserList
{
    public class FriendList
    {
        public List<Friend> Friends { get; set; }

        public FriendList()
        {
            Friends = new List<Friend>();
        }

        public string AddNewFriend(Friend newFriend)
        {
            if (GetFriendById(newFriend.GetId())!=null)
            {
                return "Friend [" + newFriend.GetId() + "] is not a new friend.";
            }
            Friends.Add(newFriend);
            return null;
        }

        public Friend GetFriendById(string id)
        {
            foreach (var friend in Friends)
            {
                if (friend.GetId().Equals(id))
                {
                    return friend;
                }
            }

            return null;
        }

        public string UpdateFriend(Friend newFriend)
        {
            foreach (var friend in Friends)
            {
                if (friend.GetId().Equals(newFriend.GetId()))
                {
                    friend.Update(newFriend);
                    return null;
                }
            }

            return "Can't find friend [" + newFriend.GetId() + "].";
        }

        public void RemoveFriendById(string id)
        {
            foreach (var friend in Friends)
            {
                if (friend.GetId().Equals(id))
                {
                    Friends.Remove(friend);
                }
            }
        }
        
        public FriendList Copy()
        {
            FriendList copy = new FriendList();
            foreach (var friend in Friends)
            {
                copy.AddNewFriend(friend.Copy());
            }
            return copy;
        }
    }
}