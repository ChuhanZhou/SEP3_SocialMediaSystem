namespace SEP3_Client.Model.Unit.User
{
    public class UserState
    {
        public bool Online { get; set; }
        public string State { get; set; }
        
        public UserState()
        {
            Online = false;
        }

        public void Login()
        {
            Online = true;
            State = "online";
        }

        public void Logoff()
        {
            Online = false;
        }

        public void SetState(string state) {
            State = state;
        }

        public string GetState() {
            if (Online)
            {
                return "[" + State + "]";
            }
            else
            {
                return "[offline]";
            }
        }

        public bool IsOnline() {
            return Online;
        }

        public UserState Copy()
        {
            return new UserState
            {
                Online = Online,
                State = State
            };
        }
    }
}