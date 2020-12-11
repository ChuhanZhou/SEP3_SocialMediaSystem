using System.Collections.Generic;
using System.Threading.Tasks;
using SEP3_Client.Model;
using SEP3_Client.Model.List.Group;
using SEP3_Client.Model.List.Message;
using SEP3_Client.Model.List.PostList;
using SEP3_Client.Model.List.UserList;
using SEP3_Client.Model.Unit.Group;
using SEP3_Client.Model.Unit.Message;
using SEP3_Client.Model.Unit.Post;
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
        string ChangePassword(string oldPassword, string newPassword);
        string UpdateBasicInformation(Account account);
        bool SearchId(string id);
        string AddNewFriend(FriendSetting newFriendSetting);
        FriendSettingList GetFriendSettingList();
        string UpdateFriendSetting(FriendSetting newFriendSetting);
        void RemoveFriend(string id);
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
        //PostSystem
        Task<string> AddPost(Post post);
        Task<PostList> GetPost();
        Task<string> UpdatePostLike(string postId);
        Task<string> AddComment(string postId,Comment comment);
        Task<string> RemoveComment(string postId,string commentId);
        Task<string> UpdatePostBySender(Post newPost);
        Task RemovePost(string postId);
    }
}