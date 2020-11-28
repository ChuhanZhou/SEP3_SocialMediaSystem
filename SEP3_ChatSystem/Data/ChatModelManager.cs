using System;
using System.Collections.Generic;
using SEP3_ChatSystem.Mediator;
using SEP3_ChatSystem.Model.List.Group;
using SEP3_ChatSystem.Model.List.Message;
using SEP3_ChatSystem.Model.Unit.Group;
using SEP3_ChatSystem.Model.Unit.Message;

namespace SEP3_ChatSystem.Data
{
    public class ChatModelManager : IChatModel
    {
        private List<ServerHandler> handlers;
        private ChatGroupList chatGroupList;
        private PrivateMessageList privateMessageList;
        private GroupMessageList groupMessageList;

        public ChatModelManager()
        {
            handlers = new List<ServerHandler>();
            chatGroupList = ChatGroupList.GetAllGroupList();
            privateMessageList = new PrivateMessageList();
            groupMessageList = new GroupMessageList();
        }
        
        private string GetRandomId()
        {
            string randomId = "";
            for (int x=0;x<8;x++)
            {
                randomId += new Random().Next(0, 16).ToString("X");
            }
            return randomId;
        }
        
        public void AddHandler(ServerHandler handler)
        {
            handlers.Add(handler);
        }

        public void RemoveHandler(ServerHandler handler)
        {
            handlers.Remove(handler);
        }

        public string AddNewGroup(ChatGroup chatGroup, string userId)
        {
            if (chatGroup.CreatorId==userId)
            {
                string newId = GetRandomId();
                while (chatGroupList.HasGroupId(newId))
                {
                    newId = GetRandomId();
                }
                ChatGroup newGroup = new ChatGroup(newId, chatGroup);
                chatGroupList.AddNewGroup(newGroup);
                UpdateChatGroup(newGroup);
                return null;
            }
            return "Wrong creator.";
        }

        public ChatGroupList GetChatGroupByUserId(string userId)
        {
            return chatGroupList.GetGroupByUserId(userId).Copy();
        }

        public string UpdateGroup(ChatGroup chatGroup, string userId)
        {
            ChatGroup oldGroup = chatGroupList.GetGroupByGroupId(chatGroup.GroupId);
            if (oldGroup!=null)
            {
                if (oldGroup.HasId(userId))
                {
                    //check creator id
                    if (chatGroup.CreatorId!=oldGroup.CreatorId&&userId!=oldGroup.CreatorId)
                    {
                        return "You can't change creator id";
                    }
                    //check group name
                    if (chatGroup.GroupName!=oldGroup.GroupName&&userId!=oldGroup.CreatorId)
                    {
                        return "You can't change group name";
                    }

                    oldGroup.CreatorId = chatGroup.CreatorId;
                    oldGroup.GroupName = chatGroup.GroupName;
                    UpdateChatGroup(oldGroup);
                    return null;
                }
                else
                {
                    return "You are not a member in this chat group.";
                }
            }
            else
            {
                return "Wrong group.";
            }
        }

        public string AddNewGroupMember(string groupId, string newUserId, string userId)
        {
            var targetGroup = chatGroupList.GetGroupByGroupId(groupId);
            if (targetGroup!=null)
            {
                if (targetGroup.HasId(userId))
                {
                    if (!targetGroup.HasId(newUserId))
                    {
                        return targetGroup.AddAccountId(newUserId);
                    }
                    return "The user[" + newUserId + "] is not a new member in this group.";
                }
                return "You are not a member in this group.";
            }
            return "Can't find the chat group [" + groupId + "].";
        }

        public string RemoveGroupMember(string groupId, string removeUserId, string userId)
        {
            var targetGroup = chatGroupList.GetGroupByGroupId(groupId);
            if (targetGroup!=null)
            {
                if (targetGroup.HasId(userId))
                {
                    if (removeUserId!=userId&&targetGroup.CreatorId!=userId)
                    {
                        return "You can't remove other user.";
                    }
                    if(removeUserId==userId&&targetGroup.CreatorId==userId)
                    {
                        return "You are the creator of this group, you can't remove yourself.";
                    }
                    targetGroup.RemoveAccountById(removeUserId);
                    return null;
                }
                return "You are not a member in this group.";
            }
            return "Can't find the chat group [" + groupId + "].";
        }

        public string RemoveGroup(ChatGroup chatGroup, string userId)
        {
            ChatGroup oldGroup = chatGroupList.GetGroupByGroupId(chatGroup.GroupId);
            if (oldGroup!=null)
            {
                if (userId==oldGroup.CreatorId)
                {
                    chatGroupList.RemoveGroupByGroupId(oldGroup.GroupId);
                    UpdateChatGroup(oldGroup);
                    return null;
                }
                else
                {
                    return "You are not the creator.";
                }
            }
            else
            {
                return "Wrong group.";
            }
        }

        public string AddNewPrivateMessage(PrivateMessage message)
        {
            privateMessageList.AddMessage(message);
            SendNewMessage(message);
            return null;
        }

        public PrivateMessageList GetPrivateMessageById(string id)
        {
            return privateMessageList.GetMessageById(id).Copy();
        }

        public string AddNewGroupMessage(GroupMessage message)
        {
            groupMessageList.AddMessage(message);
            SendNewMessage(message);
            return null;
        }

        public GroupMessageList GetGroupMessageByUserId(string userId)
        {
            return groupMessageList.GetMessageByUserId(userId).Copy();
        }

        public GroupMessageList GetGroupMessageByGroupId(string groupId)
        {
            return groupMessageList.GetMessageByGroupId(groupId).Copy();
        }

        private void UpdateChatGroup(ChatGroup group)
        {
            foreach (var handler in handlers)
            {
                if (group.HasId(handler.GetId()))
                {
                    handler.UpdateChatGroup();
                }
            }
        }

        private void SendNewMessage(Message message)
        {
            foreach (var handler in handlers)
            {
                if (message.CanRead(handler.GetId()))
                {
                    handler.NewMessage(message);
                }
            }
        }
    }
}