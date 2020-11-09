namespace SEP3_Client.Model.Unit.User
{
    public abstract class User
    {
        public string Id { get; set; }
        public UserState UserState { get; set; }

        public User(string id)
        {
            Id = id;
            UserState = new UserState();
        }
        
        public string GetId()
        {
            return Id;
        }
        
        public UserState GetUserState() 
        {
            return UserState;
        }
    }
}