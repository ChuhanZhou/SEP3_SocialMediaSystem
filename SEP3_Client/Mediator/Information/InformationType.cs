﻿using System.Text.Json.Serialization;

namespace SEP3_Client.Mediator.Information
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum InformationType
    {
        LOGIN,ACCOUNT,FRIEND,ERROR,SEARCH,SETTING,PRIVATE_MESSAGE,GROUP_MESSAGE,CHAT_GROUP
    }
}