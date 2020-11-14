using System.Collections.Generic;
using System.Threading.Tasks;
using SEP3_Client.Model;
using SEP3_Client.Model.List.UserList;
using SEP3_Client.Model.Unit.User;

namespace SEP3_Client.Data
{
    public interface IClientModel
    {
        bool HasFunction(FunctionType functionType);
        string Login(string id, string password);
        void Logoff();
        string Register(string userName, string password);
        Account GetAccount();
        Task<string> ChangePassword(string oldPassword, string newPassword);
        Task<string> UpdateBasicInformation(Account account);
        string AddNewFriend(string id);
        FriendSettingList GetFriendSettingList();
        string UpdateFriendSetting(FriendSetting newFriendSetting);
        void RemoveFriend(string id);
        Friend GetFriendById(string id);
    }
}