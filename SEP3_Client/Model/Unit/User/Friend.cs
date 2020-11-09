using System;

namespace SEP3_Client.Model.Unit.User
{
    public class Friend : UserInformation
    {
        public Friend(Account account) : base(account.GetId(),account.GetUserName())
        {
            SetBirthday(account.GetBirthday());
        }

        public Friend(string id, string userName, DateTime birthday) : base(id, userName)
        {
            SetBirthday(birthday);
        }

        public void Update(Friend friend) 
        {
            Update(friend.GetUserName(),friend.GetBirthday());
        }
        
        public Friend Copy() 
        {
            return new Friend(GetId(),GetUserName(),GetBirthday());
        }
    }
}