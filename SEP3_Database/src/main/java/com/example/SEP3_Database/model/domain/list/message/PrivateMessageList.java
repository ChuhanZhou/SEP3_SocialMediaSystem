package com.example.SEP3_Database.model.domain.list.message;

import com.example.SEP3_Database.model.domain.unit.message.PrivateMessage;

import java.util.ArrayList;

public class PrivateMessageList {
    private ArrayList<PrivateMessage> MessageList;

    public PrivateMessageList()
    {
        MessageList = new ArrayList<>();
    }

    public void AddMessage(PrivateMessage newMessage)
    {
        MessageList.add(newMessage);
    }

    public int GetSize()
    {
        return MessageList.size();
    }

    public PrivateMessage GetMessageByIndex(int index)
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

    public PrivateMessageList GetMessageBySenderId(String id)
    {
        var messageList = new PrivateMessageList();
        for (int x=0;x<MessageList.size();x++)
        {
            if (MessageList.get(x).SenderId==id)
            {
                messageList.AddMessage(MessageList.get(x));
            }
        }
        return messageList;
    }

    public PrivateMessageList GetMessageByReceiverId(String id)
    {
        var messageList = new PrivateMessageList();
        for (int x=0;x<MessageList.size();x++)
        {
            if (MessageList.get(x).getReceiverId()==id)
            {
                messageList.AddMessage(MessageList.get(x));
            }
        }
        return messageList;
    }

    public PrivateMessageList GetMessageById(String id)
    {
        var messageList = new PrivateMessageList();
        for (int x=0;x<MessageList.size();x++)
        {
            if (MessageList.get(x).SenderId==id||MessageList.get(x).getReceiverId()==id)
            {
                messageList.AddMessage(MessageList.get(x));
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
