using SEP3_Client.Model.List.Message;
using SEP3_Client.Model.Unit.Message;

namespace SEP3_Client.Mediator.Information
{
    public class PrivateMessagePackage : InformationPackage
    {
        public PrivateMessageList SendList { get; set; }

        public PrivateMessagePackage(PrivateMessageList messageList,string keyword) : base(InformationType.PRIVATE_MESSAGE,keyword)
        {
            SendList = messageList;
        }
        
        public PrivateMessagePackage(PrivateMessage message,string keyword) : base(InformationType.PRIVATE_MESSAGE,keyword)
        {
            SendList = new PrivateMessageList();
            SendList.AddMessage(message);
        }
        
        public PrivateMessagePackage(){}
    }
}