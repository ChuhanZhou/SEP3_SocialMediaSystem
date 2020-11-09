using System;

namespace SEP3_Client.Model.User
{
    public abstract class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public DateTime Birthday { get; set; }

        public User(string id, string userName)
        {
            Id = id;
            UserName = userName;
        }
    }
}