using SEP3_Client.Model.List.Message;
using SEP3_Client.Model.Unit.Message;

namespace SEP3_Client.Mediator.Information
{
    public class GroupMessagePackage : InformationPackage
    {
        public GroupMessageList SendList { get; set; }

        public GroupMessagePackage(GroupMessageList messageList,string keyword) : base(InformationType.GROUP_MESSAGE,keyword)
        {
            SendList = messageList;
        }
        
        public GroupMessagePackage(GroupMessage message,string keyword) : base(InformationType.GROUP_MESSAGE,keyword)
        {
            SendList = new GroupMessageList();
            SendList.AddMessage(message);
        }
    }
}