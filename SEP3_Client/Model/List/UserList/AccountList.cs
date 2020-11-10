using System;
using System.Collections.Generic;
using SEP3_Client.Model.Unit.User;

namespace SEP3_Client.Model.List.UserList
{
    public class AccountList
    {
        public List<Account> Accounts { get; set; }

        public AccountList()
        {
            Accounts = new List<Account>();
        }

        public string AddNewAccount(Account newAccount)
        {
            if (GetAccountById(newAccount.GetId())!=null)
            {
                return "Account [" + newAccount.GetId() + "] is not a new account.";
            }
            Accounts.Add(newAccount);
            return null;
        }
        
        public string AddOldAndNewAccount(Account oldAccount,Account newAccount)
        {
            Accounts = new List<Account> {oldAccount, newAccount};
            return null;
        }
        
        public Account GetAccountByIndex(int index)
        {
            if (index>=0&&index<Accounts.Count)
            {
                return Accounts[index];
            }
            else
            {
                return null;
            }
        }

        public Account GetAccountById(string id)
        {
            foreach (var account in Accounts)
            {
                if (account.GetId().Equals(id))
                {
                    return account;
                }
            }
            return null;
        }

        public string ChangePassword(string id,string oldPassword,string newPassword)
        {
            foreach (var account in Accounts)
            {
                if (account.GetId().Equals(id))
                {
                    return account.ChangePassWord(oldPassword, newPassword);
                }
            }

            return "Can't find user [" + id + "].";
        }

        public string UpdateAccount(Account newAccount)
        {
            foreach (var account in Accounts)
            {
                if (account.GetId().Equals(newAccount.GetId()))
                {
                    account.Update(newAccount);
                    return null;
                }
            }

            return "Can't find account [" + newAccount.GetId() + "].";
        }

        public void RemoveAccountById(string id)
        {
            foreach (var account in Accounts)
            {
                if (account.GetId().Equals(id))
                {
                    Accounts.Remove(account);
                    break;
                }
            }
        }

        public AccountList Copy()
        {
            AccountList copy = new AccountList();
            foreach (var account in Accounts)
            {
                copy.AddNewAccount(account.Copy());
            }
            return copy;
        }
    }
}