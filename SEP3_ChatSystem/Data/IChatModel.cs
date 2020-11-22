using SEP3_ChatSystem.Model.List.Group;
using SEP3_ChatSystem.Model.List.Message;
using SEP3_ChatSystem.Model.Unit.Group;
using SEP3_ChatSystem.Model.Unit.Message;

namespace SEP3_ChatSystem.Data
{
    public interface IChatModel
    {
        string AddNewGroup(ChatGroup chatGroup);
        ChatGroupList GetChatGroupByUserId(string userId);
        string UpdateGroup(ChatGroup chatGroup, string userId);
        string RemoveGroup(ChatGroup chatGroup, string userId);
        string AddNewPrivateMessage(PrivateMessage message);
        PrivateMessageList GetPrivateMessageById(string id);
        string AddNewGroupMessage(GroupMessage message);
        GroupMessageList GetGroupMessageByUserId(string userId);
        GroupMessageList GetGroupMessageByGroupId(string groupId);
    }
}