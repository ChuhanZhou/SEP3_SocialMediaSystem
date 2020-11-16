using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Threading.Tasks;
using SEP3_Client.Mediator;
using SEP3_Client.Model;
using SEP3_Client.Model.List.UserList;
using SEP3_Client.Model.Unit.User;

namespace SEP3_Client.Data
{
    public class ClientModelManager : IClientModel,IClientModelForUserSystem
    {
        private List<FunctionType> FunctionTypes;
        private Account account;
        private FriendList friendList;
        private IUserSystemClient userSystemClient;
        public ClientModelManager()
        {
            FunctionTypes = new List<FunctionType>();
            userSystemClient = new UserSystemClient();
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
                FunctionTypes.Add(FunctionType.UserSystem);
                return userSystemClient.SendLoginOrRegisterPackage("login",id,password);
            }
            FunctionTypes.Remove(FunctionType.UserSystem);
            return "Can't connect UserSystem.";
        }

        public void Logoff()
        {
            userSystemClient.SendAccountPackage(account, "logoff");
            userSystemClient.Disconnect();
            FunctionTypes.Remove(FunctionType.UserSystem);
        }

        public string Register(string userName, string password)
        {
            if (userSystemClient.Connect(this))
            {
                FunctionTypes.Add(FunctionType.UserSystem);
                return userSystemClient.SendLoginOrRegisterPackage("register",userName,password);
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
            return friendList.GetFriendById(id).Copy();
        }

        public void UpdateAccount(Account account)
        {
            this.account = account;
        }

        public void UpdateFriendList(FriendList friendList)
        {
            this.friendList = friendList;
        }
    }
}