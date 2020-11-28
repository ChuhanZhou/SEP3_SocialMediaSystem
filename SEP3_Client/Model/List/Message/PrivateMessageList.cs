using System.Collections.Generic;
using System.Linq;
using SEP3_Client.Model.Unit.Message;

namespace SEP3_Client.Model.List.Message
{
    public class PrivateMessageList
    {
        public List<PrivateMessage> MessageList { get; set; }

        public PrivateMessageList()
        {
            MessageList = new List<PrivateMessage>();
        }

        public void AddMessage(PrivateMessage newMessage)
        {
            MessageList.Add(newMessage);
        }

        public int GetSize()
        {
            return MessageList.Count;
        }

        public PrivateMessage GetMessageByIndex(int index)
        {
            if (index>=0&&index<MessageList.Count)
            {
                return MessageList[index];
            }
            else
            {
                return null;
            }
        }

        public PrivateMessageList GetMessageBySenderId(string id)
        {
            var messageList = new PrivateMessageList();
            foreach (var message in MessageList)
            {
                if (message.SenderId==id)
                {
                    messageList.AddMessage(message);
                }
            }
            return messageList;
        }
        
        public PrivateMessageList GetMessageByReceiverId(string id)
        {
            var messageList = new PrivateMessageList();
            foreach (var message in MessageList)
            {
                if (message.ReceiverId==id)
                {
                    messageList.AddMessage(message);
                }
            }
            return messageList;
        }
        
        public PrivateMessageList GetMessageById(string id)
        {
            var messageList = new PrivateMessageList();
            foreach (var message in MessageList)
            {
                if (message.SenderId==id||message.ReceiverId==id)
                {
                    messageList.AddMessage(message);
                }
            }
            return messageList;
        }

        public void RemoveMessageById(string senderId, string receiverId)
        {
            if (!string.IsNullOrEmpty(senderId))
            {
                if (!string.IsNullOrEmpty(receiverId))
                {
                    foreach (var message in MessageList.Where(message => message.SenderId==senderId&&message.ReceiverId==receiverId))
                    {
                        MessageList.Remove(message);
                    }
                }
                else
                {
                    foreach (var message in MessageList.Where(message => message.SenderId==senderId))
                    {
                        MessageList.Remove(message);
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(receiverId))
                {
                    foreach (var message in MessageList.Where(message => message.ReceiverId==receiverId))
                    {
                        MessageList.Remove(message);
                    }
                }
            }
        }

        public PrivateMessageList Copy()
        {
            var messageList = new PrivateMessageList();
            foreach (var message in MessageList)
            {
                messageList.AddMessage(message.Copy());
            }
            return messageList;
        }
    }
}