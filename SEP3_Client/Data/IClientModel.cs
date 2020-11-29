using System.Collections.Generic;
using System.Threading.Tasks;
using SEP3_Client.Model;
using SEP3_Client.Model.List.Group;
using SEP3_Client.Model.List.Message;
using SEP3_Client.Model.List.UserList;
using SEP3_Client.Model.Unit.Group;
using SEP3_Client.Model.Unit.Message;
using SEP3_Client.Model.Unit.User;

namespace SEP3_Client.Data
{
    public interface IClientModel
    {
        bool HasFunction(FunctionType functionType);
        string Login(string id, string password);
        void Logoff();
        string Register(string userName, string password);
        //UserSystem
        Account GetAccount();
        Task<string> ChangePassword(string oldPassword, string newPassword);
        Task<string> UpdateBasicInformation(Account account);
        Task<bool> SearchId(string id);
        Task<string> AddNewFriend(FriendSetting newFriendSetting);
        FriendSettingList GetFriendSettingList();
        Task<string> UpdateFriendSetting(FriendSetting newFriendSetting);
        Task RemoveFriend(string id);
        Friend GetFriendById(string id);
        //ChatSystem
        string AddNewGroup(string groupName);
        ChatGroupList GetGroupList();
        ChatGroup GetGroupByGroupId(string groupId);
        string UpdateGroupInformation(ChatGroup chatGroup);
        string AddGroupMember(ChatGroup chatGroup, string newMemberId);
        string RemoveGroupMember(ChatGroup chatGroup, string removeMemberId);
        string RemoveGroup(ChatGroup chatGroup);
        PrivateMessageList GetMessageById(string id);
        GroupMessageList GetMessageByGroupId(string groupId);
        string SendPrivateMessage(PrivateMessage message);
        string SendGroupMessage(GroupMessage message);
        PrivateMessageList GetOfflineMessageById(string id);
        GroupMessageList GetOfflineMessageByGroupId(string groupId);
    }
}