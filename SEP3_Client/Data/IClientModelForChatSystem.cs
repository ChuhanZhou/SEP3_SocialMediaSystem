using SEP3_Client.Model;
using SEP3_Client.Model.List.Group;
using SEP3_Client.Model.List.Message;
using SEP3_Client.Model.Unit.Message;
using SEP3_Client.Model.Unit.User;

namespace SEP3_Client.Data
{
    public interface IClientModelForChatSystem
    {
        bool HasFunction(FunctionType functionType);
        void SystemOnLine(FunctionType functionType);
        void SystemOffLine(FunctionType functionType);
        Account GetAccount();
        void UpdateChatGroupList(ChatGroupList chatGroupList);
        void UpdatePrivateMessageList(PrivateMessageList privateMessageList);
        void UpdateGroupMessageList(GroupMessageList groupMessageList);
        void AddPrivateMessage(PrivateMessage newMessage);
        void AddGroupMessage(GroupMessage newMessage);
    }
}