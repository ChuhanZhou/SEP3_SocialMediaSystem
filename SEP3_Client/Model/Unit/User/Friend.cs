using System;

namespace SEP3_Client.Model.Unit.User
{
    public class Friend : BasicInformation
    {
        public Friend(Account account) : base(account.GetId(),account.GetUserName())
        {
            SetBirthday(account.GetBirthday());
        }

        public Friend(string id, string userName, Birthday birthday) : base(id, userName)
        {
            SetBirthday(birthday);
        }

        private Friend(Friend friend) : base(friend) {}
        
        public Friend() {}

        public void Update(Friend friend) 
        {
            Update(friend.GetUserName(),friend.GetBirthday(),friend.Gender,friend.Hometown,friend.PhoneNumber);
        }
        
        public Friend Copy() 
        {
            return new Friend(this);
        }
    }
}