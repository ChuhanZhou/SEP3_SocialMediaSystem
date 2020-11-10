using SEP3_Client.Data;
using SEP3_Client.Model.Unit.User;

namespace SEP3_Client.Mediator
{
    public interface UserSystemClientModel
    {
        bool Connect(IClientModel clientModel);
        void Disconnect();
        void SendAccountPackage();
        void SendFriendPackage();
        void SendSearchPackage();
        void Start(string keyword, Account account);
    }
}