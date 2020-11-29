using SEP3_Client.Model.List.Group;

namespace SEP3_Client.Model.Unit.Message
{
    public class GroupMessage : Message
    {
        public string GroupId { get; set; }

        public GroupMessage(string senderId, string groupId, string messageInfo) : base(senderId, messageInfo,
            MessageType.GROUP)
        {
            GroupId = groupId;
        }
        
        public GroupMessage() {}
        
        public GroupMessage Copy()
        {
            return new GroupMessage
            {
                MessageInfo = MessageInfo,
                Type = Type,
                SenderId = SenderId,
                Time = Time,
                GroupId = GroupId
            };
        }

        public override bool CanRead(string userId)
        {
            return userId == SenderId || ChatGroupList.GetAllGroupList().GetGroupByGroupId(GroupId).HasId(userId);
        }
    }
}