using System.Text.Json.Serialization;

namespace SEP3_Client.Model.Unit.User
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FriendSettingStatus
    {
        AGREE,DISAGREE,WAITAGREE,NEEDAGREE,DELETE
    }
}