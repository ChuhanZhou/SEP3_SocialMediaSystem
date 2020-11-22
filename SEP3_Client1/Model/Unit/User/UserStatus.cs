namespace SEP3_Client.Model.Unit.User
{
    public class UserStatus
    {
        public bool Online { get; set; }
        public string Status { get; set; }
        
        public UserStatus()
        {
            Online = false;
        }

        public void Login()
        {
            Online = true;
            Status = "online";
        }

        public void Logoff()
        {
            Online = false;
        }

        public void SetStatus(string status) {
            Status = status;
        }

        public string GetStatus() {
            if (Online)
            {
                return "[" + Status + "]";
            }
            else
            {
                return "[offline]";
            }
        }

        public bool IsOnline() {
            return Online;
        }

        public UserStatus Copy()
        {
            return new UserStatus
            {
                Online = Online,
                Status = Status
            };
        }
    }
}