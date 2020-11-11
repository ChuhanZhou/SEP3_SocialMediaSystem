using System;

namespace SEP3_Client.Model.Unit.User
{
    public abstract class BasicInformation : User
    {
        public string UserName { get; set; }
        public Birthday Birthday { get; set; }
        
        public BasicInformation(string id,string userName) : base(id)
        {
            UserName = userName;
        }

        public BasicInformation()
        {
            
        }
        
        public string GetUserName() 
        {
            return UserName;
        }

        public void SetUserName(string userName) 
        {
            UserName = userName;
        }

        public Birthday GetBirthday() 
        {
            return Birthday;
        }

        public void SetBirthday(Birthday birthday) 
        {
            Birthday = birthday;
        }

        public void Update(string userName,Birthday birthday) 
        {
            UserName = userName;
            Birthday = birthday;
        }
    }
}