namespace SEP3_ChatSystem.Model.Unit.Message
{
    public class PrivateMessage : Message
    {
        public string ReceiverId { get; set; }

        public PrivateMessage(string senderId, string receiverId, string messageInfo) : base(senderId, messageInfo,
            MessageType.PRIVATE)
        {
            ReceiverId = receiverId;
        }
        
        public PrivateMessage() {}

        public PrivateMessage Copy()
        {
            return new PrivateMessage
            {
                MessageInfo = MessageInfo,
                MessageType = MessageType,
                SenderId = SenderId,
                Time = Time,
                ReceiverId = ReceiverId
            };
        }
    }
}