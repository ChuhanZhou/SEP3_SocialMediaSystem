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
        string AddNewGroup(ChatGroup chatGroup, string userId);
        ChatGroupList GetChatGroupByUserId(string userId);
        string UpdateGroup(ChatGroup chatGroup, string userId);
        string AddNewGroupMember(string groupId,string newUserId, string userId);
        string RemoveGroupMember(string groupId,string removeUserId, string userId);
        string RemoveGroup(ChatGroup chatGroup, string userId);
        string AddNewPrivateMessage(PrivateMessage message);
        PrivateMessageList GetPrivateMessageById(string id);
        string AddNewGroupMessage(GroupMessage message);
        GroupMessageList GetGroupMessageByUserId(string userId);
        GroupMessageList GetGroupMessageByGroupId(string groupId);
    }
}