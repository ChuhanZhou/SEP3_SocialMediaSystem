using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SEP3_Client.Mediator.ChatSystemClient;
using SEP3_Client.Mediator.CloudPostSystem;
using SEP3_Client.Mediator.UserSystemClient;
using SEP3_Client.Model;
using SEP3_Client.Model.List.Group;
using SEP3_Client.Model.List.Message;
using SEP3_Client.Model.List.PostList;
using SEP3_Client.Model.List.UserList;
using SEP3_Client.Model.Unit.Group;
using SEP3_Client.Model.Unit.Message;
using SEP3_Client.Model.Unit.Post;
using SEP3_Client.Model.Unit.User;

namespace SEP3_Client.Data
{
    public class ClientModelManager : IClientModel,IClientModelForUserSystem,IClientModelForChatSystem,IClientModelForPostSystem
    {
        private List<FunctionType> FunctionTypes;
        private Account account;
        private FriendList friendList;
        private ChatGroupList chatGroupList;
        private PrivateMessageList privateMessageList;
        private GroupMessageList groupMessageList;

        private PrivateMessageList offlinePrivateMessageList;
        private GroupMessageList offlineGroupMessageList;
        
        private IUserSystemClient userSystemClient;
        private IChatSystemClient chatSystemClient;
        private ICloudPostSystem postSystem;
        public ClientModelManager()
        {
            Init();
            userSystemClient = new UserSystemClient(2030,"localhost");
            chatSystemClient = new ChatSystemClient(3010,"localhost");
            postSystem = new CloudPostSystem(this);
        }

        private void Init()
        {
            FunctionTypes = new List<FunctionType>();
            account = new Account();
            friendList = new FriendList();
            chatGroupList = ChatGroupList.GetAllGroupList();
            privateMessageList = new PrivateMessageList();
            groupMessageList = new GroupMessageList();
            offlinePrivateMessageList = new PrivateMessageList();
            offlineGroupMessageList = new GroupMessageList();
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
            Init();
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

        public string ChangePassword(string oldPassword, string newPassword)
        {
            Account oldAccount = new Account(account.GetId(), account.GetUserName(), oldPassword);
            Account newAccount = new Account(account.GetId(), account.GetUserName(), newPassword);
            return userSystemClient.SendAccountPackage(oldAccount,newAccount, "changePassword");
        }

        public string UpdateBasicInformation(Account account)
        {
            Account oldAccount = this.account;
            Account newAccount = account;
            
            return userSystemClient.SendAccountPackage(oldAccount,newAccount, "updateBasicInformation");
        }

        public bool SearchId(string id)
        {
            return userSystemClient.SendSearchPackage(id, "hasUser");
        }

        public string AddNewFriend(FriendSetting newFriendSetting)
        {
            return userSystemClient.SendFriendSettingPackage(newFriendSetting,"addNewFriend");
        }

        public FriendSettingList GetFriendSettingList()
        {
            return account.FriendSettingList.Copy();
        }

        public string UpdateFriendSetting(FriendSetting newFriendSetting)
        {
            
            return userSystemClient.SendFriendSettingPackage(newFriendSetting,"updateFriend");
        }

        public void RemoveFriend(string id)
        {
            FriendSetting newFriendSetting = account.GetFriendSettingList().GetFriendSettingFromAgreeById(id).Copy();
            newFriendSetting.Delete();
            userSystemClient.SendFriendSettingPackage(newFriendSetting,"removeFriend");
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
            return groupMessageList.GetMessageByGroupId(groupId).Copy();
        }

        public string SendPrivateMessage(PrivateMessage message)
        {
            if (!HasFunction(FunctionType.ChatSystem))
            {
                offlinePrivateMessageList.AddMessage(message);
                UpdatePage.ChatSystemUpdate();
            }
            return chatSystemClient.SendPrivateMessagePackage(message);
        }

        public string SendGroupMessage(GroupMessage message)
        {
            if (!HasFunction(FunctionType.ChatSystem))
            {
                offlineGroupMessageList.AddMessage(message);
                UpdatePage.ChatSystemUpdate();
            }
            return chatSystemClient.SendGroupMessagePackage(message);
        }

        public PrivateMessageList GetOfflineMessageById(string id)
        {
            return offlinePrivateMessageList.GetMessageById(id).Copy();
        }

        public GroupMessageList GetOfflineMessageByGroupId(string groupId)
        {
            return offlineGroupMessageList.GetMessageByGroupId(groupId).Copy();
        }

        public async Task<string> AddPost(Post post)
        {
            var result = await postSystem.AddPost(post, account.Id);
            await UpdatePage.PostSystemUpdate();
            return result;
        }

        public async Task<PostList> GetPost()
        {
            return await postSystem.GetPost(account.Id);
        }

        public async Task<string> UpdatePostLike(string postId)
        {
            var result = await postSystem.UpdatePostLike(postId,account.Id);
            await UpdatePage.PostSystemUpdate();
            return result;
        }

        public async Task<string> AddComment(string postId, Comment comment)
        {
            var result = await postSystem.AddComment(postId, comment, account.Id);
            await UpdatePage.PostSystemUpdate();
            return result;
        }

        public async Task<string> RemoveComment(string postId, string commentId)
        {
            var result = await postSystem.RemoveComment(postId, commentId, account.Id);
            await UpdatePage.PostSystemUpdate();
            return result;
        }

        public async Task<string> UpdatePostBySender(Post newPost)
        {
            var result = await postSystem.UpdatePostBySender(newPost, account.Id);
            await UpdatePage.PostSystemUpdate();
            return result;
        }

        public async Task RemovePost(string postId)
        {
            await postSystem.RemovePost(postId, account.Id);
            await UpdatePage.PostSystemUpdate();
        }

        public void SystemOnLine(FunctionType functionType)
        {
            FunctionTypes.Add(functionType);
            new Thread(()=>
            {
                if (functionType==FunctionType.ChatSystem)
                {
                    if (offlinePrivateMessageList.GetSize()>0)
                    {
                        chatSystemClient.SendPrivateMessagePackage(offlinePrivateMessageList);
                        offlinePrivateMessageList = new PrivateMessageList();
                    }
                    if (offlineGroupMessageList.GetSize()>0)
                    {
                        chatSystemClient.SendGroupMessagePackage(offlineGroupMessageList);
                        offlineGroupMessageList = new GroupMessageList();
                    }
                    UpdatePage.ChatSystemUpdate();
                }
            }).Start();
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