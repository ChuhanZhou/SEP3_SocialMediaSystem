using SEP3_Client.Model.List.UserList;
using SEP3_Client.Model.Unit.User;

namespace SEP3_Client.Mediator.Information
{
    public class AccountPackage : InformationPackage
    {
        public AccountList SendList { get; set; }

        public AccountPackage(AccountList accountList,string keyword) : base(InformationType.ACCOUNT,keyword)
        {
            SendList = accountList.Copy();
        }

        public AccountPackage(Account account,string keyword) : base(InformationType.ACCOUNT,keyword)
        {
            SendList = new AccountList();
            SendList.AddNewAccount(account);
        }

        public AccountList GetSendList() {
            return SendList;
        }
    }
}