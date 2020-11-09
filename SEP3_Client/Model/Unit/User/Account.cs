using System;
using SEP3_Client.Model.List.UserList;

namespace SEP3_Client.Model.Unit.User
{
    public class Account : UserInformation
    {
        public string Password { get; set; }
        public FriendSettingList FriendSettingList { get; set; }
        public Account(string id, string userName,string password) : base(id, userName)
        {
            Password = password;
            FriendSettingList = new FriendSettingList();
        }

        private Account(string id, string userName, DateTime birthday, string password, FriendSettingList friendSettingList) : this(id, userName, password)
        {
            SetBirthday(birthday);
            FriendSettingList = friendSettingList;
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
            return new Account(GetId(),GetUserName(),GetBirthday(),Password,FriendSettingList.Copy());
        }
    }
}