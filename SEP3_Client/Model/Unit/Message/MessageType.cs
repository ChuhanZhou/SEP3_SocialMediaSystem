using System.Text.Json.Serialization;

namespace SEP3_Client.Model.Unit.Message
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MessageType
    {
        PRIVATE,GROUP
    }
}