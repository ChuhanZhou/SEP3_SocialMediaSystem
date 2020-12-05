using System;
using System.Collections.Generic;
using System.Linq;
using SEP3_ChatSystem.Model.List.Group;
using SEP3_ChatSystem.Model.Unit.Group;
using SEP3_ChatSystem.Model.Unit.Message;

namespace SEP3_ChatSystem.Model.List.Message
{
    public class GroupMessageList
    {
        public List<GroupMessage> MessageList { get; set; }

        public GroupMessageList()
        {
            MessageList = new List<GroupMessage>();
        }

        public void AddMessage(GroupMessage newMessage)
        {
            MessageList.Add(newMessage);
        }

        public int GetSize()
        {
            return MessageList.Count;
        }

        public GroupMessage GetMessageByIndex(int index)
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

        public GroupMessageList GetMessageBySenderId(string id)
        {
            var messageList = new GroupMessageList();
            foreach (var message in MessageList)
            {
                if (message.SenderId==id)
                {
                    messageList.AddMessage(message);
                }
            }
            return messageList;
        }
        
        public GroupMessageList GetMessageByGroupId(string id)
        {
            var messageList = new GroupMessageList();
            foreach (var message in MessageList)
            {
                if (message.GroupId==id)
                {
                    messageList.AddMessage(message);
                }
            }
            return messageList;
        }
        
        public GroupMessageList GetMessageByUserId(string id)
        {
            var messageList = new GroupMessageList();
            foreach (var message in MessageList)
            { 
                if (ChatGroupList.GetAllGroupList().GetGroupByGroupId(message.GroupId).HasId(id))
                {
                    messageList.AddMessage(message);
                }
            }
            return messageList;
        }
        
        public void RemoveMessageById(string senderId, string groupId)
        {
            GroupMessageList copy = Copy();
            if (!string.IsNullOrEmpty(senderId))
            {
                if (!string.IsNullOrEmpty(groupId))
                {
                    foreach (var message in copy.MessageList.Where(message => message.SenderId==senderId&&message.GroupId==groupId))
                    {
                        MessageList.Remove(message);
                    }
                }
                else
                {
                    foreach (var message in copy.MessageList.Where(message => message.SenderId==senderId))
                    {
                        MessageList.Remove(message);
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(groupId))
                {
                    foreach (var message in copy.MessageList.Where(message => message.GroupId==groupId))
                    {
                        MessageList.Remove(message);
                    }
                }
            }
        }
        
        public GroupMessageList Copy()
        {
            var messageList = new GroupMessageList();
            foreach (var message in MessageList)
            {
                messageList.AddMessage(message.Copy());
            }
            return messageList;
        }
    }
}