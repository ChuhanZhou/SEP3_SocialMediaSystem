namespace SEP3_Client.Model.Unit.User
{
    public abstract class  User
    {
        public string Id { get; set; }
        public UserStatus UserStatus { get; set; }

        public User(string id)
        {
            Id = id;
            UserStatus = new UserStatus();
        }

        public User()
        {
            
        }
        
        public string GetId()
        {
            return Id;
        }
        
        public UserStatus GetUserStatus() 
        {
            return UserStatus;
        }

        public void SetUserStatus(UserStatus userStatus)
        {
            UserStatus = userStatus;
        }
    }
}