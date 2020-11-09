using System.Collections.Generic;
using SEP3_Client.Model.Unit.User;

namespace SEP3_Client.Model.List.UserList
{
    public class FriendSettingList
    {
        public List<FriendSetting> FriendSettings { get; set; }

        public FriendSettingList()
        {
            FriendSettings = new List<FriendSetting>();
        }
        
        public string AddNewFriendSetting(FriendSetting newFriend)
        {
            if (GetFriendSettingById(newFriend.GetId())!=null)
            {
                return "Friend: " + newFriend.GetNote() + "[" + newFriend.GetId() + "] is not a new friend.";
            }
            else
            {
                FriendSettings.Add(newFriend);
                return null;
            }
        }

        public FriendSetting GetFriendSettingById(string id)
        {
            foreach (var friendSetting in FriendSettings)
            {
                if (friendSetting.GetId().Equals(id))
                {
                    return friendSetting.Copy();
                }
            }

            return null;
        }
        
        public List<FriendSetting> GetFriendSettingList()
        {
            var copy = new List<FriendSetting>();
            foreach (var friendSetting in FriendSettings)
            {
                copy.Add(friendSetting.Copy());
            }
            return copy;
        }

        public string UpdateFriendSetting(FriendSetting newFriendSetting)
        {
            foreach (var friendSetting in FriendSettings)
            {
                if (friendSetting.GetId().Equals(newFriendSetting.GetId()))
                {
                    friendSetting.SetNote(newFriendSetting.GetNote());
                    friendSetting.SetDisablePost(newFriendSetting.IsDisablePost());
                    return null;
                }
            }

            return "Can't find the friend: " + newFriendSetting.GetNote() + "[" + newFriendSetting.GetId() + "]";
        }

        public void RemoveFriendSettingById(string id)
        {
            for (int x = 0; x< FriendSettings.Count; x++)
            {
                if (FriendSettings[x].GetId().Equals(id))
                {
                    FriendSettings.RemoveAt(x);
                    break;
                }
            }
        }

        public FriendSettingList Copy()
        {
            FriendSettingList copy = new FriendSettingList();
            foreach (var friendSetting in FriendSettings)
            {
                copy.AddNewFriendSetting(friendSetting.Copy());
            }
            return copy;
        }
    }
}