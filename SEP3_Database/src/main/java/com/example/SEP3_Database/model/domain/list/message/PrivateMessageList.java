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
            if (MessageList.get(x).SenderId==id)
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
            if (MessageList.get(x).getReceiverId()==id)
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
            if (MessageList.get(x).SenderId==id||MessageList.get(x).getReceiverId()==id)
            {
                messageList.addMessage(MessageList.get(x));
            }
        }
        return messageList;
    }

    public void RemoveMessageById(String senderId, String receiverId)
    {
        ArrayList<PrivateMessage> copyList = this.copy().MessageList;
        if (senderId!=null)
        {
            if (receiverId!=null)
            {
                for (int x=0;x<copyList.size();x++)
                {
                    if (copyList.get(x).SenderId==senderId&&copyList.get(x).getReceiverId()==receiverId)
                    {
                        MessageList.remove(copyList.get(x));
                    }
                }
            }
            else
            {
                for (int x=0;x<copyList.size();x++)
                {
                    if (copyList.get(x).SenderId==senderId)
                    {
                        MessageList.remove(copyList.get(x));
                    }
                }
            }
        }
        else
        {
            if (receiverId!=null)
            {
                for (int x=0;x<copyList.size();x++)
                {
                    if (copyList.get(x).getReceiverId()==receiverId)
                    {
                        MessageList.remove(copyList.get(x));
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
