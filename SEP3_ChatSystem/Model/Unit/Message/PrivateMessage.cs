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
    }
}