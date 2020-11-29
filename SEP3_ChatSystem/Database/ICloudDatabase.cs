using System.Threading.Tasks;
using SEP3_ChatSystem.Model.List.Group;
using SEP3_ChatSystem.Model.List.Message;
using SEP3_ChatSystem.Model.Unit.Group;
using SEP3_ChatSystem.Model.Unit.Message;

namespace SEP3_ChatSystem.Database
{
    public interface ICloudDatabase
    {
        Task AddChatGroup(ChatGroup chatGroup);
        Task<ChatGroupList> GetAllChatGroup();
        Task UpdateChatGroup(ChatGroup chatGroup);
        Task RemoveChatGroup(ChatGroup chatGroup);
        Task AddPrivateMessage(PrivateMessage privateMessage);
        Task<PrivateMessageList> GetAllPrivateMessage();
        Task AddGroupMessage(GroupMessage groupMessage);
        Task<GroupMessageList> GetAllGroupMessage();
    }
}