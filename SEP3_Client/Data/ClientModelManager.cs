﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SEP3_Client.Mediator.ChatSystemClient;
using SEP3_Client.Mediator.UserSystemClient;
using SEP3_Client.Model;
using SEP3_Client.Model.List.Group;
using SEP3_Client.Model.List.Message;
using SEP3_Client.Model.List.UserList;
using SEP3_Client.Model.Unit.Group;
using SEP3_Client.Model.Unit.Message;
using SEP3_Client.Model.Unit.User;

namespace SEP3_Client.Data
{
    public class ClientModelManager : IClientModel,IClientModelForUserSystem,IClientModelForChatSystem
    {
        private List<FunctionType> FunctionTypes;
        private Account account;
        private FriendList friendList;
        private ChatGroupList chatGroupList;
        private PrivateMessageList privateMessageList;
        private GroupMessageList groupMessageList;
        
        private IUserSystemClient userSystemClient;
        private IChatSystemClient chatSystemClient;
        public ClientModelManager()
        {
            FunctionTypes = new List<FunctionType>();
            userSystemClient = new UserSystemClient();
            chatSystemClient = new ChatSystemClient();
            chatGroupList = ChatGroupList.GetAllGroupList();
        }
        
        public bool HasFunction(FunctionType functionType)
        {
            foreach (var type in FunctionTypes)
            {
                if (type==functionType)
                {
                    return true;
                }
            }
            return false;
        }

        public string Login(string id, string password)
        {
            if (userSystemClient.Connect(this))
            {
                string result = userSystemClient.SendLoginOrRegisterPackage("login",id,password);
                if (result==null)
                {
                    ConnectChatSystem();
                }
                return result;
            }
            return "Can't connect UserSystem.";
        }

        private void ConnectChatSystem()
        {
            new Thread(()=>
            {
                chatSystemClient.Connect(this);
            }).Start();
        }

        public void Logoff()
        {
            userSystemClient.SendAccountPackage(account, "logoff");
            userSystemClient.Disconnect();
            chatSystemClient.Logoff();
        }

        public string Register(string userName, string password)
        {
            if (userSystemClient.Connect(this))
            {
                string result = userSystemClient.SendLoginOrRegisterPackage("register",userName,password);
                if (result==null)
                {
                    ConnectChatSystem();
                }
                return result;
            }
            FunctionTypes.Remove(FunctionType.UserSystem);
            return "Can't connect UserSystem.";
        }

        public Account GetAccount()
        {
            return account.Copy();
        }

        public async Task<string> ChangePassword(string oldPassword, string newPassword)
        {
            Account oldAccount = new Account(account.GetId(), account.GetUserName(), oldPassword);
            Account newAccount = new Account(account.GetId(), account.GetUserName(), newPassword);
            return await userSystemClient.SendAccountPackage(oldAccount,newAccount, "changePassword");
        }

        public async Task<string> UpdateBasicInformation(Account account)
        {
            Account oldAccount = this.account;
            Account newAccount = account;
            
            return await userSystemClient.SendAccountPackage(oldAccount,newAccount, "updateBasicInformation");
        }

        public async Task<bool> SearchId(string id)
        {
            return await userSystemClient.SendSearchPackage(id, "hasUser");
        }

        public async Task<string> AddNewFriend(FriendSetting newFriendSetting)
        {
            return await userSystemClient.SendFriendSettingPackage(newFriendSetting,"addNewFriend");
        }

        public FriendSettingList GetFriendSettingList()
        {
            return account.FriendSettingList.Copy();
        }

        public async Task<string> UpdateFriendSetting(FriendSetting newFriendSetting)
        {
            
            return await userSystemClient.SendFriendSettingPackage(newFriendSetting,"updateFriend");
        }

        public async Task RemoveFriend(string id)
        {
            FriendSetting newFriendSetting = account.GetFriendSettingList().GetFriendSettingFromAgreeById(id).Copy();
            newFriendSetting.Delete();
            await userSystemClient.SendFriendSettingPackage(newFriendSetting,"removeFriend");
        }

        public Friend GetFriendById(string id)
        {
            Friend friend = friendList.GetFriendById(id);
            if (friend!=null)
            {
                return friendList.GetFriendById(id).Copy();
            }
            return null;
        }

        public string AddNewGroup(string groupName)
        {
            return chatSystemClient.SendChatGroupPackage(new ChatGroup(groupName,account.Id), null, "Add");
        }

        public ChatGroupList GetGroupList()
        {
            return chatGroupList.Copy();
        }

        public ChatGroup GetGroupByGroupId(string groupId)
        {
            return chatGroupList.GetGroupByGroupId(groupId).Copy();
        }

        public string UpdateGroupInformation(ChatGroup chatGroup)
        {
            return chatSystemClient.SendChatGroupPackage(chatGroup, null, "Update");
        }

        public string AddGroupMember(ChatGroup chatGroup, string newMemberId)
        {
            return chatSystemClient.SendChatGroupPackage(chatGroup, newMemberId, "AddUser");
        }

        public string RemoveGroupMember(ChatGroup chatGroup, string removeMemberId)
        {
            return chatSystemClient.SendChatGroupPackage(chatGroup, removeMemberId, "RemoveUser");
        }

        public string RemoveGroup(ChatGroup chatGroup)
        {
            return chatSystemClient.SendChatGroupPackage(chatGroup, null, "Remove");

        }

        public PrivateMessageList GetMessageById(string id)
        {
            return privateMessageList.GetMessageById(id).Copy();
        }

        public GroupMessageList GetMessageByGroupId(string groupId)
        {
            return groupMessageList.GetMessageByGroupId(groupId);
        }

        public string SendPrivateMessage(PrivateMessage message)
        {
            return chatSystemClient.SendPrivateMessagePackage(message);
        }

        public string SendGroupMessage(GroupMessage message)
        {
            return chatSystemClient.SendGroupMessagePackage(message);
        }

        public void SystemOnLine(FunctionType functionType)
        {
            FunctionTypes.Add(functionType);
        }

        public void SystemOffLine(FunctionType functionType)
        {
            FunctionTypes.Remove(functionType);
        }

        public void UpdateChatGroupList(ChatGroupList chatGroupList)
        {
            this.chatGroupList.GroupList = chatGroupList.Copy().GroupList;
            UpdatePage.ChatSystemUpdate();
        }

        public void UpdatePrivateMessageList(PrivateMessageList privateMessageList)
        {
            this.privateMessageList = privateMessageList.Copy();
            UpdatePage.ChatSystemUpdate();
        }

        public void UpdateGroupMessageList(GroupMessageList groupMessageList)
        {
            this.groupMessageList = groupMessageList.Copy();
            UpdatePage.ChatSystemUpdate();
        }

        public void AddPrivateMessage(PrivateMessage newMessage)
        {
            privateMessageList.AddMessage(newMessage);
            UpdatePage.ChatSystemUpdate();
        }

        public void AddGroupMessage(GroupMessage newMessage)
        {
            groupMessageList.AddMessage(newMessage);
            UpdatePage.ChatSystemUpdate();
        }

        public void UpdateAccount(Account account)
        {
            this.account = account;
            UpdatePage.UserSystemUpdate();
        }

        public void UpdateFriendList(FriendList friendList)
        {
            this.friendList = friendList;
            UpdatePage.UserSystemUpdate();
        }
    }
}