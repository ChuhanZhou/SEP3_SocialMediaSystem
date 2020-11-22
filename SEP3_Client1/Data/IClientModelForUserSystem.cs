using SEP3_Client.Model;
using SEP3_Client.Model.List.UserList;
using SEP3_Client.Model.Unit.User;

namespace SEP3_Client.Data
{
    public interface IClientModelForUserSystem
    {
        bool HasFunction(FunctionType functionType);
        void SystemOnLine(FunctionType functionType);
        void SystemOffLine(FunctionType functionType);
        void UpdateAccount(Account account);
        void UpdateFriendList(FriendList friendList);
    }
}