using System;
using System.Text.Json.Serialization;
using SEP3_ChatSystem.Model.Unit.Time;

namespace SEP3_ChatSystem.Model.Unit.Message
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public abstract class Message
    {
        public string MessageInfo { get; set; }
        public MessageType MessageType { get; set; }
        public string SenderId { get; set; }
        public MyTime Time { get; set; }
        public Message(string senderId,string messageInfo,MessageType messageType)
        {
            SenderId = senderId;
            MessageInfo = messageInfo;
            MessageType = messageType;
            Time = new MyTime(DateTime.Now);
        }
        
        public Message() {}

        public abstract bool CanRead(string userId);
    }
}