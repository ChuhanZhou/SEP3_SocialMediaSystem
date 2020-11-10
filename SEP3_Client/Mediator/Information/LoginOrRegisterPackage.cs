namespace SEP3_Client.Mediator.Information
{
    public class LoginOrRegisterPackage : InformationPackage
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public LoginOrRegisterPackage(string keyword,string idOrName,string password) : base(InformationType.LOGIN,keyword)
        {
            switch (keyword)
            {
                case "login":
                    Id = idOrName;
                    break;
                case "register":
                    Name = idOrName;
                    break;
                default:
                    break;
            }
            Password = password;
        }

        public string GetId() {
            return Id;
        }

        public string GetPassword() {
            return Password;
        }
        
        public string GetName() {
            return Name;
        }
    }
}