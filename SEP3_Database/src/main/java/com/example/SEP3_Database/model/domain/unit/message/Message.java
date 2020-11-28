package com.example.SEP3_Database.model.domain.unit.message;

import com.google.api.client.util.DateTime;

import java.sql.Time;
import java.time.Clock;
import java.time.LocalDateTime;
import java.util.Date;

public abstract class Message {
    public String MessageInfo;
    public MessageType MessageType;
    public String SenderId;
    public LocalDateTime Time;
    public Message(String senderId,String messageInfo,MessageType messageType)
    {
        SenderId = senderId;
        MessageInfo = messageInfo;
        MessageType = messageType;
        Time = LocalDateTime.now();
    }

    public abstract boolean CanRead(String userId);
}
