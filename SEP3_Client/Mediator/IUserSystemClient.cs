using SEP3_Client.Data;
using SEP3_Client.Model.Unit.User;

namespace SEP3_Client.Mediator
{
    public interface IUserSystemClient
    {
        bool Connect(IClientModelForUserSystem clientModel);
        void Disconnect();
        string SendLoginOrRegisterPackage(string keyword, string idOrName, string password);
        string SendAccountPackage(Account account,string keyword);
        string SendAccountPackage(Account oldAccount,Account newAccount,string keyword);
        void Start();
    }
}