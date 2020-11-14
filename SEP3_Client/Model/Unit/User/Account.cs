using System;
using SEP3_Client.Model.List.UserList;

namespace SEP3_Client.Model.Unit.User
{
    public class Account : BasicInformation
    {
        public string Password { get; set; }
        public FriendSettingList FriendSettingList { get; set; }
        public Account(string id, string userName,string password) : base(id, userName)
        {
            Password = password;
            FriendSettingList = new FriendSettingList();
        }

        public Account()
        {
            
        }
        
        private Account(string id, string userName, Birthday birthday, string password, FriendSettingList friendSettingList,UserState userState) : this(id, userName, password)
        {
            SetBirthday(birthday);
            SetUserState(UserState);
            FriendSettingList = friendSettingList;
        }

        public bool CheckPassword(string password)
        {
            return Password.Equals(password);
        }

        public bool CheckPassword(Account otherAccount)
        {
            return otherAccount.GetId().Equals(GetId())&&otherAccount.CheckPassword(Password);
        }

        public string ChangePassWord(string oldPassword,string newPassword) 
        {
            if (Password.Equals(oldPassword))
            {
                Password = newPassword;
                return null;
            }
            else
            {
                return "Wrong password.";
            }
        }
        
        public string ChangePassWord(Account oldAccount,Account newAccount) {
            if (GetId().Equals(newAccount.GetId())&&CheckPassword(oldAccount))
            {
                return ChangePassWord(oldAccount.Password,newAccount.Password);
            }
            else 
            {
                return "Wrong change.";
            }
        }

        public FriendSettingList GetFriendSettingList() 
        {
            return FriendSettingList;
        }

        public void SetFriendSettingList(FriendSettingList friendSettingList) 
        {
            FriendSettingList = friendSettingList;
        }

        public void Update(Account account)
        {
            Update(account.GetUserName(),account.GetBirthday());
            FriendSettingList = account.GetFriendSettingList();
        }
        
        public Account Copy() 
        {
            return new Account(GetId(),GetUserName(),GetBirthday(),Password,FriendSettingList.Copy(),UserState.Copy());
        }
    }
}