using System.Text.Json.Serialization;

namespace SEP3_ChatSystem.Model.Unit.Message
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public abstract class Message
    {
        public string MessageInfo { get; set; }
        public MessageType MessageType { get; set; }
        
        public string SenderId { get; set; }

        public Message(string senderId,string messageInfo,MessageType messageType)
        {
            SenderId = senderId;
            MessageInfo = messageInfo;
            MessageType = messageType;
        }
    }
}