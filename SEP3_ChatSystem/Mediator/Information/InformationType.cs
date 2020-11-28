using System.Text.Json.Serialization;

namespace SEP3_ChatSystem.Mediator.Information
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum InformationType
    {
        ERROR,PRIVATE_MESSAGE,GROUP_MESSAGE,CHAT_GROUP
    }
}