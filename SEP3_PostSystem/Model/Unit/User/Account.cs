using SEP3_PostSystem.Model.List.UserList;

namespace SEP3_PostSystem.Model.Unit.User
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
        
        private Account(string id, string userName, Birthday birthday, char gender, string homeTown, long phoneNumber, string password, FriendSettingList friendSettingList,UserStatus userStatus) : this(id, userName, password)
        {
            SetBirthday(birthday);
            SetGender(gender);
            SetHomeTown(homeTown);
            SetPhoneNumber(phoneNumber);
            SetUserStatus(userStatus);
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
            Update(account.UserName,account.Birthday,account.Gender,account.Hometown,account.PhoneNumber);
            FriendSettingList = account.GetFriendSettingList();
        }
        
        public Account Copy() 
        {
            return new Account(GetId(),GetUserName(),GetBirthday(),Gender,Hometown,PhoneNumber,Password,FriendSettingList.Copy(),UserStatus.Copy());
        }
    }
}