package com.example.SEP3_Database.model.domain.list.message;

import com.example.SEP3_Database.model.domain.unit.message.PrivateMessage;

import java.util.ArrayList;

public class PrivateMessageList {
    private ArrayList<PrivateMessage> MessageList;

    public PrivateMessageList()
    {
        MessageList = new ArrayList<>();
    }

    public void addMessage(PrivateMessage newMessage)
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

    public PrivateMessage getMessageByIndex(int index)
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

    public PrivateMessageList getMessageBySenderId(String id)
    {
        var messageList = new PrivateMessageList();
        for (int x=0;x<MessageList.size();x++)
        {
            if (MessageList.get(x).SenderId.equals(id))
            {
                messageList.addMessage(MessageList.get(x));
            }
        }
        return messageList;
    }

    public PrivateMessageList getMessageByReceiverId(String id)
    {
        var messageList = new PrivateMessageList();
        for (int x=0;x<MessageList.size();x++)
        {
            if (MessageList.get(x).getReceiverId().equals(id))
            {
                messageList.addMessage(MessageList.get(x));
            }
        }
        return messageList;
    }

    public PrivateMessageList getMessageById(String id)
    {
        var messageList = new PrivateMessageList();
        for (int x=0;x<MessageList.size();x++)
        {
            if (MessageList.get(x).SenderId.equals(id) || MessageList.get(x).getReceiverId().equals(id))
            {
                messageList.addMessage(MessageList.get(x));
            }
        }
        return messageList;
    }

    public void RemoveMessageById(String senderId, String receiverId)
    {
        ArrayList<PrivateMessage> privateMessageList = new ArrayList<>();
        if (senderId!=null)
        {
            if (receiverId!=null)
            {
                for (int x=0;x<MessageList.size();x++)
                {
                    if (!MessageList.get(x).SenderId.equals(senderId) || !MessageList.get(x).getReceiverId().equals(receiverId))
                    {
                        privateMessageList.add(MessageList.get(x));
                    }
                }
            }
            else
            {
                for (int x=0;x<MessageList.size();x++)
                {
                    if (!MessageList.get(x).SenderId.equals(senderId))
                    {
                        privateMessageList.add(MessageList.get(x));
                    }
                }
            }
        }
        else
        {
            if (receiverId!=null)
            {
                for (int x=0;x<MessageList.size();x++)
                {
                    if (!MessageList.get(x).getReceiverId().equals(receiverId))
                    {
                        privateMessageList.add(MessageList.get(x));
                    }
                }
            }
        }
    }

    public PrivateMessageList copy()
    {
        var messageList = new PrivateMessageList();
        for (int x=0;x<MessageList.size();x++)
        {
            messageList.MessageList.add(MessageList.get(x).copy());
        }
        return messageList;
    }
}
