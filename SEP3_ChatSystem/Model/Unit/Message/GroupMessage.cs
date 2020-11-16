namespace SEP3_ChatSystem.Model.Unit.Message
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
                MessageType = MessageType,
                SenderId = SenderId,
                Time = Time,
                GroupId = GroupId
            };
        }
    }
}