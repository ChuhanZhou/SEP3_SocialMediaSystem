package com.example.SEP3_Database.model.domain.list.message;

import com.example.SEP3_Database.model.domain.unit.message.GroupMessage;

import java.util.ArrayList;

public class GroupMessageList {
    private ArrayList<GroupMessage> MessageList;

    public GroupMessageList()
    {
        MessageList = new ArrayList<>();
    }

    public void addMessage(GroupMessage newMessage)
    {
        if (newMessage!=null)
        {
            MessageList.add(newMessage);
        }
    }

    public int getSize()
    {
        return MessageList.size();
    }

    public GroupMessage getMessageByIndex(int index)
    {
        if (index>=0&&index<MessageList.size())
        {
            return MessageList.get(index);
        }
        else
        {
            return null;
        }
    }

    public GroupMessageList getMessageBySenderId(String id)
    {
        var messageList = new GroupMessageList();
        for (int x=0;x<MessageList.size();x++)
        {
            if (MessageList.get(x).SenderId.equals(id))
            {
                messageList.addMessage(MessageList.get(x));
            }
        }
        return messageList;
    }

    public GroupMessageList getMessageByGroupId(String id)
    {
        var messageList = new GroupMessageList();
        for (int x=0;x<MessageList.size();x++)
        {
            if (MessageList.get(x).getGroupId().equals(id))
            {
                messageList.addMessage(MessageList.get(x));
            }
        }
        return messageList;
    }

    public void removeMessageById(String senderId, String groupId)
    {
        ArrayList<GroupMessage> groupMessageList = new ArrayList<>();
        if (senderId!=null)
        {
            if (groupId!=null)
            {
                for (int x=0;x<MessageList.size();x++)
                {
                    if (!MessageList.get(x).SenderId.equals(senderId) || !MessageList.get(x).getGroupId().equals(groupId))
                    {
                        groupMessageList.add(MessageList.get(x));
                    }
                }
            }
            else
            {
                for (int x=0;x<MessageList.size();x++)
                {
                    if (!MessageList.get(x).SenderId.equals(senderId))
                    {
                        groupMessageList.add(MessageList.get(x));
                    }
                }
            }
        }
        else
        {
            if (groupId!=null)
            {
                for (int x=0;x<MessageList.size();x++)
                {
                    if (!MessageList.get(x).getGroupId().equals(groupId))
                    {
                        groupMessageList.add(MessageList.get(x));
                    }
                }
            }
        }
        MessageList = groupMessageList;
    }

    public GroupMessageList copy()
    {
        var messageList = new GroupMessageList();
        for (int x=0;x<MessageList.size();x++)
        {
            messageList.MessageList.add(MessageList.get(x).copy());
        }
        return messageList;
    }
}
