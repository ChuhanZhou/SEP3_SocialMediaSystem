using System;
using System.Text.Json.Serialization;

namespace SEP3_Client.Model.Unit.Message
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public abstract class Message
    {
        public string MessageInfo { get; set; }
        public MessageType MessageType { get; set; }
        public string SenderId { get; set; }
        public DateTime Time { get; set; }
        public Message(string senderId,string messageInfo,MessageType messageType)
        {
            SenderId = senderId;
            MessageInfo = messageInfo;
            MessageType = messageType;
            Time = DateTime.Now;
        }
        
        public Message() {}

        public abstract bool CanRead(string userId);
    }
}