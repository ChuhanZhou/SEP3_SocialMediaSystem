using SEP3_Client.Data;
using SEP3_Client.Model.List.Message;
using SEP3_Client.Model.Unit.Group;
using SEP3_Client.Model.Unit.Message;

namespace SEP3_Client.Mediator.ChatSystemClient
{
    public interface IChatSystemClient
    {
        bool Connect(IClientModelForChatSystem clientModel);
        void Login();
        void Logoff();
        string SendChatGroupPackage(ChatGroup chatGroup,string targetId,string keyword);
        string SendPrivateMessagePackage(PrivateMessageList privateMessageList);
        string SendPrivateMessagePackage(PrivateMessage privateMessage);
        string SendGroupMessagePackage(GroupMessageList groupMessageList);
        string SendGroupMessagePackage(GroupMessage groupMessage);
    }
}