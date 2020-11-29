package com.example.SEP3_Database.model.domain.unit.message;

import com.example.SEP3_Database.model.domain.unit.time.MyTime;

public class PrivateMessage extends Message{
    private String ReceiverId;

    public PrivateMessage(String senderId, String receiverId, String messageInfo)
    {
        super(senderId, messageInfo, MessageType.PRIVATE);
        ReceiverId = receiverId;
    }

    public PrivateMessage(String senderId,String receiverId,String messageInfo,MyTime time)
    {
        super(senderId, messageInfo, MessageType.PRIVATE,time);
        ReceiverId = receiverId;
    }

    public String getReceiverId() {
        return ReceiverId;
    }

    public void setReceiverId(String receiverId) {
        ReceiverId = receiverId;
    }

    public PrivateMessage copy()
    {
        return new PrivateMessage(super.SenderId,ReceiverId,super.MessageInfo,super.Time);
    }
}
