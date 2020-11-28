using SEP3_Client.Model.List.Group;
using SEP3_Client.Model.Unit.Group;

namespace SEP3_Client.Mediator.Information
{
    public class ChatGroupPackage : InformationPackage
    {
        public ChatGroupList SendList { get; set; }
        public string TargetId { get; set; }

        public ChatGroupPackage(ChatGroupList groupList,string keyword) : base(InformationType.CHAT_GROUP,keyword)
        {
            SendList = groupList;
            TargetId = null;
        }
        
        public ChatGroupPackage(ChatGroup chatGroup,string keyword) : base(InformationType.CHAT_GROUP,keyword)
        {
            SendList = new ChatGroupList();
            TargetId = null;
            SendList.AddNewGroup(chatGroup);
        }
        
        public ChatGroupPackage(ChatGroup chatGroup,string targetId,string keyword) : base(InformationType.CHAT_GROUP,keyword)
        {
            TargetId = targetId;
            SendList = new ChatGroupList();
            SendList.AddNewGroup(chatGroup);
        }
    }
}