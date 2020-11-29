package com.example.SEP3_Database.model.domain.unit.message;

import com.example.SEP3_Database.model.domain.unit.time.MyTime;

public class GroupMessage extends Message{
    private String GroupId;

    public GroupMessage(String senderId, String groupId, String messageInfo)
    {
        super(senderId, messageInfo, MessageType.GROUP);
        GroupId = groupId;
    }

    public GroupMessage(String senderId, String groupId, String messageInfo, MyTime time)
    {
        super(senderId, messageInfo, MessageType.PRIVATE,time);
        GroupId = groupId;
    }

    public String getGroupId() {
        return GroupId;
    }

    public void setGroupId(String groupId) {
        GroupId = groupId;
    }

    public GroupMessage copy()
    {
        return new GroupMessage(super.SenderId,GroupId,super.MessageInfo,super.Time);
    }
}
