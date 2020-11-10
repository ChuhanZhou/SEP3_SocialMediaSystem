using SEP3_Client.Model.List.UserList;
using SEP3_Client.Model.Unit.User;

namespace SEP3_Client.Data
{
    public interface IClientModelForUserSystem
    {
        void UpdateAccount(Account account);
        void UpdateFriendList(FriendList friendList);
    }
}