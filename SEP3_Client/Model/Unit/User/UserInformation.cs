using System;

namespace SEP3_Client.Model.Unit.User
{
    public abstract class UserInformation : User
    {
        public string UserName { get; set; }
        public DateTime Birthday { get; set; }
        
        public UserInformation(string id,string userName) : base(id)
        {
            UserName = userName;
        }
        
        public string GetUserName() 
        {
            return UserName;
        }

        public void SetUserName(string userName) 
        {
            UserName = userName;
        }

        public DateTime GetBirthday() 
        {
            return Birthday;
        }

        public void SetBirthday(DateTime birthday) 
        {
            Birthday = birthday;
        }

        public void Update(string userName,DateTime birthday) 
        {
            UserName = userName;
            Birthday = birthday;
        }
    }
}