using System.Collections.Generic;
using SEP3_PostSystem.Model.Unit.User;

namespace SEP3_PostSystem.Model.List.UserList
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
            if (newFriend!=null)
            {
                if (GetFriendSettingFromAgreeById(newFriend.GetId())!=null)
                {
                    return "Friend: " + newFriend.GetNote() + "[" + newFriend.GetId() + "] is not a new friend.";
                }
                else
                {
                    FriendSettings.Add(newFriend);
                    return null;
                }
            }

            return "Input null.";
        }

        public FriendSetting GetFriendSettingFromAgreeById(string id)
        {
            FriendSettingList agreeList = GetFriendSettingListByStatus(FriendSettingStatus.AGREE);
            foreach (var friendSetting in agreeList.FriendSettings)
            {
                if (friendSetting.GetId().Equals(id))
                {
                    return friendSetting;
                }
            }
            return null;
        }

        public FriendSetting GetFriendSettingFromUnconfirmedById(string id)
        {
            foreach (var friendSetting in FriendSettings)
            {
                if (friendSetting.NeedAgree()||friendSetting.WaitAgree())
                {
                    if (friendSetting.GetId().Equals(id))
                    {
                        return friendSetting;
                    }
                }
            }
            return null;
        }

        public FriendSetting GetFriendSettingFromNeedAgreeById(string id)
        {
            foreach (var friendSetting in FriendSettings)
            {
                if (friendSetting.NeedAgree()&&friendSetting.GetId().Equals(id))
                {
                    return friendSetting;
                }
            }
            return null;
        }

        public FriendSetting GetFriendSettingFromWaitAgreeById(string id)
        {
            foreach (var friendSetting in FriendSettings)
            {
                if (friendSetting.WaitAgree()&&friendSetting.GetId().Equals(id))
                {
                    return friendSetting;
                }
            }
            return null;
        }
        
        public FriendSettingList GetFriendSettingListById(string id)
        {
            FriendSettingList friendSettingList = new FriendSettingList();
            foreach (var friendSetting in FriendSettings)
            {
                if (friendSetting.GetId().Equals(id))
                {
                    friendSettingList.FriendSettings.Add(friendSetting);
                }
            }
            return friendSettingList;
        }
        
        public FriendSettingList GetFriendSettingListByStatus(FriendSettingStatus status)
        {
            FriendSettingList searchList = new FriendSettingList();
            foreach (var friendSetting in FriendSettings)
            {
                if (friendSetting.GetStatus().Equals(status))
                {
                    searchList.FriendSettings.Add(friendSetting);
                }
            }
            return searchList;
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
                if (friendSetting.GetStatus()==FriendSettingStatus.AGREE)
                {
                    if (friendSetting.GetId().Equals(newFriendSetting.GetId()))
                    {
                        friendSetting.SetNote(newFriendSetting.GetNote());
                        friendSetting.SetDisablePost(newFriendSetting.IsDisablePost());
                        return null;
                    }
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
                copy.FriendSettings.Add(friendSetting.Copy());
            }
            return copy;
        }
    }
}