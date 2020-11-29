package com.example.SEP3_Database.model.domain.unit.message;

import com.example.SEP3_Database.model.domain.unit.time.MyTime;
import java.time.LocalDateTime;


public abstract class Message {
    public String MessageInfo;
    public MessageType Type;
    public String SenderId;
    public MyTime Time;
    public Message(String senderId,String messageInfo,MessageType type)
    {
        SenderId = senderId;
        MessageInfo = messageInfo;
        Type = type;
        Time = new MyTime(LocalDateTime.now());
    }

    public Message(String senderId,String messageInfo,MessageType type,MyTime time)
    {
        SenderId = senderId;
        MessageInfo = messageInfo;
        Type = type;
        Time = time;
    }

    public String getMessageInfo() {
        return MessageInfo;
    }

    public void setMessageInfo(String messageInfo) {
        MessageInfo = messageInfo;
    }

    public MessageType getMessageType() {
        return Type;
    }

    public void setMessageType(MessageType type) {
        Type = type;
    }

    public String getSenderId() {
        return SenderId;
    }

    public void setSenderId(String senderId) {
        SenderId = senderId;
    }

    public MyTime getTime() {
        return Time;
    }

    public void setTime(MyTime time) {
        Time = time;
    }
}
