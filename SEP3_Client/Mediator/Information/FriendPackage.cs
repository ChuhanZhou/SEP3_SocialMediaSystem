using SEP3_Client.Model.List.UserList;
using SEP3_Client.Model.Unit.User;

namespace SEP3_Client.Mediator.Information
{
    public class FriendPackage : InformationPackage
    {
        public FriendList SendList { get; set; }
        
        public FriendPackage(FriendList friendList,string keyword) : base(InformationType.FRIEND,keyword)
        {
            SendList = friendList.Copy();
        }

        public FriendPackage(Friend friend,string keyword) : base(InformationType.FRIEND,keyword)
        {
            SendList = new FriendList();
            SendList.AddNewFriend(friend);
        }

        public FriendPackage()
        {
            
        }
        
        public FriendList GetSendList() {
            return SendList;
        }
    }
}