﻿using System.Text.Json.Serialization;

namespace SEP3_ChatSystem.Model.Unit.Message
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MessageType
    {
        PRIVATE,GROUP
    }
}