using System.Threading.Tasks;
using SEP3_ChatSystem.Mediator;
using SEP3_ChatSystem.Model.List.Group;
using SEP3_ChatSystem.Model.List.Message;
using SEP3_ChatSystem.Model.Unit.Group;
using SEP3_ChatSystem.Model.Unit.Message;

namespace SEP3_ChatSystem.Data
{
    public interface IChatModel
    {
        void AddHandler(ServerHandler handler);
        void RemoveHandler(ServerHandler handler);
        Task<string> AddNewGroup(ChatGroup chatGroup, string userId);
        Task<ChatGroupList> GetChatGroupByUserId(string userId);
        Task<string> UpdateGroup(ChatGroup chatGroup, string userId);
        Task<string> AddNewGroupMember(string groupId,string newUserId, string userId);
        Task<string> RemoveGroupMember(string groupId,string removeUserId, string userId);
        Task<string> RemoveGroup(ChatGroup chatGroup, string userId);
        string AddNewPrivateMessage(PrivateMessage message);
        Task<PrivateMessageList> GetPrivateMessageById(string id);
        string AddNewGroupMessage(GroupMessage message);
        Task<GroupMessageList>  GetGroupMessageByUserId(string userId);
        Task<GroupMessageList>  GetGroupMessageByGroupId(string groupId);
        bool DatabaseSystemIsOnline();
    }
}