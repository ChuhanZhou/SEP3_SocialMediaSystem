using System;
using System.Text.Json.Serialization;
using SEP3_Client.Model.Unit.Time;

namespace SEP3_Client.Model.Unit.Message
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public abstract class Message
    {
        public string MessageInfo { get; set; }
        public MessageType Type { get; set; }
        public string SenderId { get; set; }
        public MyTime Time { get; set; }
        public Message(string senderId,string messageInfo,MessageType type)
        {
            SenderId = senderId;
            MessageInfo = messageInfo;
            Type = type;
            Time = new MyTime(DateTime.Now);
        }
        
        public Message() {}

        public abstract bool CanRead(string userId);
    }
}