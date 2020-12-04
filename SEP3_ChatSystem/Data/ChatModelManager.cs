using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SEP3_ChatSystem.Database;
using SEP3_ChatSystem.Mediator;
using SEP3_ChatSystem.Model.List.Group;
using SEP3_ChatSystem.Model.List.Message;
using SEP3_ChatSystem.Model.Unit.Group;
using SEP3_ChatSystem.Model.Unit.Message;

namespace SEP3_ChatSystem.Data
{
    public class ChatModelManager : IChatModel,IChatModelForDatabase
    {
        private List<ServerHandler> handlers;
        private ChatGroupList chatGroupList;
        private PrivateMessageList privateMessageList;
        private GroupMessageList groupMessageList;
        private ICloudDatabase cloudDatabase;
        private bool databaseOnline;

        public ChatModelManager()
        {
            handlers = new List<ServerHandler>();
            chatGroupList = ChatGroupList.GetAllGroupList();
            privateMessageList = new PrivateMessageList();
            groupMessageList = new GroupMessageList();
            databaseOnline = true;
            cloudDatabase = new CloudDatabase(this);
        }
        
        private static string GetRandomId()
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

        public async Task<string> AddNewGroup(ChatGroup chatGroup, string userId)
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
                await cloudDatabase.AddChatGroup(newGroup);
                await UpdateChatGroup(newGroup);
                return null;
            }
            return "Wrong creator.";
        }

        public async Task<ChatGroupList> GetChatGroupByUserId(string userId)
        {
            chatGroupList.GroupList = (await cloudDatabase.GetAllChatGroup()).GroupList;
            return chatGroupList.GetGroupByUserId(userId).Copy();
        }

        public async Task<string> UpdateGroup(ChatGroup chatGroup, string userId)
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
                    await cloudDatabase.UpdateChatGroup(oldGroup);
                    await UpdateChatGroup(oldGroup);
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

        public async Task<string> AddNewGroupMember(string groupId, string newUserId, string userId)
        {
            var targetGroup = chatGroupList.GetGroupByGroupId(groupId);
            if (targetGroup!=null)
            {
                if (targetGroup.HasId(userId))
                {
                    if (!targetGroup.HasId(newUserId))
                    {
                        string result = targetGroup.AddAccountId(newUserId);
                        if (result==null)
                        {
                            await cloudDatabase.UpdateChatGroup(targetGroup);
                            await UpdateChatGroup(targetGroup);
                        }
                        return result;
                    }
                    return "The user[" + newUserId + "] is not a new member in this group.";
                }
                return "You are not a member in this group.";
            }
            return "Can't find the chat group [" + groupId + "].";
        }

        public async Task<string> RemoveGroupMember(string groupId, string removeUserId, string userId)
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
                    await cloudDatabase.UpdateChatGroup(targetGroup);
                    await UpdateChatGroup(targetGroup);
                    return null;
                }
                return "You are not a member in this group.";
            }
            return "Can't find the chat group [" + groupId + "].";
        }

        public async Task<string> RemoveGroup(ChatGroup chatGroup, string userId)
        {
            ChatGroup oldGroup = chatGroupList.GetGroupByGroupId(chatGroup.GroupId);
            if (oldGroup!=null)
            {
                if (userId==oldGroup.CreatorId)
                {
                    chatGroupList.RemoveGroupByGroupId(oldGroup.GroupId);
                    groupMessageList.RemoveMessageById(null,oldGroup.GroupId);
                    await cloudDatabase.RemoveChatGroup(oldGroup);
                    await UpdateChatGroup(oldGroup);
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
            cloudDatabase.AddPrivateMessage(message);
            SendNewMessage(message);
            return null;
        }

        public async Task<PrivateMessageList> GetPrivateMessageById(string id)
        {
            privateMessageList = await cloudDatabase.GetAllPrivateMessage();
            return privateMessageList.GetMessageById(id).Copy();
        }

        public string AddNewGroupMessage(GroupMessage message)
        {
            groupMessageList.AddMessage(message);
            cloudDatabase.AddGroupMessage(message);
            SendNewMessage(message);
            return null;
        }

        public async Task<GroupMessageList> GetGroupMessageByUserId(string userId)
        {
            groupMessageList = await cloudDatabase.GetAllGroupMessage();
            return groupMessageList.GetMessageByUserId(userId).Copy();
        }

        public async Task<GroupMessageList> GetGroupMessageByGroupId(string groupId)
        {
            groupMessageList = await cloudDatabase.GetAllGroupMessage();
            return groupMessageList.GetMessageByGroupId(groupId).Copy();
        }

        public bool DatabaseSystemIsOnline()
        {
            return databaseOnline;
        }

        private async Task UpdateChatGroup(ChatGroup group)
        {
            foreach (var handler in handlers)
            {
                if (group.HasId(handler.GetId()))
                {
                    await handler.UpdateChatGroup();
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

        public async Task DatabaseSystemOnline()
        {
            if (!databaseOnline)
            {
                databaseOnline = true;
                privateMessageList = await cloudDatabase.GetAllPrivateMessage();
                groupMessageList = await cloudDatabase.GetAllGroupMessage();
                Console.WriteLine("Reconnect to Database System successfully.");
                foreach (var handler in handlers)
                {
                    await handler.DatabaseOnline();
                }
            }
        }

        public void DatabaseSystemOffline()
        {
            if (databaseOnline)
            {
                databaseOnline = false;
                TryToConnectWithDatabaseSystem();
            }
        }
        
        private void TryToConnectWithDatabaseSystem()
        {
            new Thread(async ()=>{
                while (!databaseOnline)
                {
                    Console.Write("Try to reconnect with Database System in 5s.\n[");
                    for (int x=10;x>0;x--)
                    {
                        Console.Write("-");
                        Thread.Sleep(500);
                    }
                    Console.WriteLine("]\nTry reconnecting...");
                    chatGroupList.GroupList = (await cloudDatabase.GetAllChatGroup()).GroupList;
                }
            }).Start();
        }
    }
}