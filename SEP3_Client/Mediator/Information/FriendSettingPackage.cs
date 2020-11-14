using SEP3_Client.Model.List.UserList;
using SEP3_Client.Model.Unit.User;

namespace SEP3_Client.Mediator.Information
{
    public class FriendSettingPackage : InformationPackage
    {
        public FriendSettingList FriendSettingList { get; set; }
        public FriendSettingPackage(FriendSettingList friendSettingList,string keyword) : base(InformationType.SETTING,keyword)
        {
            FriendSettingList = friendSettingList;
        }

        public FriendSettingPackage(FriendSetting friendSetting,string keyword) : base(InformationType.SETTING,keyword)
        {
            FriendSettingList = new FriendSettingList();
            FriendSettingList.AddNewFriendSetting(friendSetting);
        }
        
        public FriendSettingPackage()
        {
        }

        public FriendSettingList GetFriendSettingList()
        {
            return FriendSettingList;
        }
    }
}