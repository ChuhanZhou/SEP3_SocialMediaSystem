using System;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using SEP3_Client.Data;
using SEP3_Client.Mediator.Information;
using SEP3_Client.Model;
using SEP3_Client.Model.List.UserList;
using SEP3_Client.Model.Unit.User;

namespace SEP3_Client.Mediator.UserSystemClient
{
    public class UserSystemClient : IUserSystemClient
    {
        private IClientModelForUserSystem clientModel;
        private static readonly int PORT = 2030;
        private static readonly string HOST = "localhost";
        private int port;
        private string host;

        private TcpClient client;
        private NetworkStream stream;
        private bool login;
        private bool sending;
        private bool isReceive;
        private string receiveMessage;
        
        public UserSystemClient() : this(PORT,HOST) {}

        public UserSystemClient(int port) : this(port,HOST) {}

        public UserSystemClient(string host) : this(PORT, host) {}

        public UserSystemClient(int port,string host)
        {
            this.port = port;
            this.host = host;
        }
        
        public bool Connect(IClientModelForUserSystem clientModel)
        {
            Console.WriteLine("Starting client...");
            try
            {
                client = new TcpClient(host, port);
                stream = client.GetStream();
                login = false;
                this.clientModel = clientModel;
                this.clientModel.SystemOnLine(FunctionType.UserSystem);
                new Thread(Start).Start();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Can't connect UserSystem [Exception]" + e.Message);
                //Console.WriteLine(e);
                return false;
            }
        }

        public void Disconnect()
        {
            stream.Close();
            client.Close();
            login = false;
            clientModel.SystemOffLine(FunctionType.UserSystem);
        }

        private void Send(string information)
        {
            byte[] dataToServer = Encoding.ASCII.GetBytes(information+"\r");
            Console.WriteLine("Send:"+information);
            stream.Write(dataToServer, 0, dataToServer.Length);
        }
        
        private string GetReceive()
        {
            try
            {
                byte[] dataFromServer = new byte[102400];
                int bytesRead = stream.Read(dataFromServer, 0, dataFromServer.Length);
                string receive = Encoding.ASCII.GetString(dataFromServer, 0, bytesRead);
                Console.WriteLine("Receive:"+receive);
                return receive;
            }
            catch (Exception e)
            {
                Console.WriteLine("Disconnect [Exception]" + e.Message);
                Disconnect();
                return null;
            }
        }
        
        public string SendLoginOrRegisterPackage(string keyword, string idOrName, string password)
        {
            if (clientModel.HasFunction(FunctionType.UserSystem))
            {
                login = false;
                LoginOrRegisterPackage sendPackage = new LoginOrRegisterPackage(keyword,idOrName,password);
                string send = JsonSerializer.Serialize(sendPackage);
                Send(send);
                string receive = GetReceive();
                InformationPackage informationPackage = JsonSerializer.Deserialize<InformationPackage>(receive);
                switch(informationPackage.GetInformationType())
                {
                    case InformationType.ERROR:
                        ErrorPackage errorPackage = JsonSerializer.Deserialize<ErrorPackage>(receive);
                        return errorPackage.GetKeyword();
                    case InformationType.ACCOUNT:
                        AccountPackage accountPackage = JsonSerializer.Deserialize<AccountPackage>(receive);
                        clientModel.UpdateAccount(accountPackage.SendList.GetAccountByIndex(0));
                        receive = GetReceive();
                        FriendPackage friendPackage = JsonSerializer.Deserialize<FriendPackage>(receive);
                        clientModel.UpdateFriendList(friendPackage.SendList);
                        login = true;
                        return null;
                }
                return "Get wrong package.";
            }
            else
            {
                return "User System offline.";
            }
        }

        public async Task<string> SendAccountPackage(Account account, string keyword)
        {
            if (clientModel.HasFunction(FunctionType.UserSystem))
            {
                while (sending)
                {
                    Thread.Sleep(100);
                }
                sending = true;
                isReceive = false;
                AccountPackage sendPackage = new AccountPackage(account,keyword);
                string send = JsonSerializer.Serialize(sendPackage);
                Send(send);
                while (!isReceive)
                {
                    Thread.Sleep(100);
                }
                sending = false;
                return receiveMessage;
            }
            else
            {
                return "User System offline.";
            }
        }
        
        public async Task<string> SendAccountPackage(Account oldAccount, Account newAccount, string keyword)
        {
            if (clientModel.HasFunction(FunctionType.UserSystem))
            {
                while (sending)
                {
                    Thread.Sleep(100);
                }
                sending = true;
                isReceive = false;
                AccountList sendList = new AccountList();
                sendList.AddOldAndNewAccount(oldAccount, newAccount);
                AccountPackage sendPackage = new AccountPackage(sendList,keyword);
                string send = JsonSerializer.Serialize(sendPackage);
                Send(send);
                while (!isReceive)
                {
                    Thread.Sleep(100);
                }
                sending = false;
                return receiveMessage;
            }
            else
            {
                return "User System offline.";
            }
        }

        public async Task<string> SendFriendSettingPackage(FriendSetting friendSetting, string keyword)
        {
            if (clientModel.HasFunction(FunctionType.UserSystem))
            {
                while (sending)
                {
                    Thread.Sleep(100);
                }
                sending = true;
                isReceive = false;
                FriendSettingPackage sendPackage = new FriendSettingPackage(friendSetting,keyword);
                string send = JsonSerializer.Serialize(sendPackage);
                Send(send);
                while (!isReceive)
                {
                    Thread.Sleep(100);
                }
                sending = false;
                return receiveMessage;
            }
            else
            {
                return "User System offline.";
            }
        }

        public async Task<bool> SendSearchPackage(string id, string keyword)
        {
            if (clientModel.HasFunction(FunctionType.UserSystem))
            {
                while (sending)
                {
                    Thread.Sleep(100);
                }
                sending = true;
                isReceive = false;
                SearchPackage sendPackage = new SearchPackage(id,keyword);
                string send = JsonSerializer.Serialize(sendPackage);
                Send(send);
                while (!isReceive)
                {
                    Thread.Sleep(100);
                }
                sending = false;
                return bool.Parse(receiveMessage);
            }
            else
            {
                return false;
            }
        }

        public void Start()
        {
            while (clientModel.HasFunction(FunctionType.UserSystem))
            {
                while (login)
                {
                    var receive = GetReceive();
                    try
                    {
                        var informationPackage = JsonSerializer.Deserialize<InformationPackage>(receive);
                        switch (informationPackage.GetInformationType())
                        {
                            case InformationType.ACCOUNT:
                                var accountPackage = JsonSerializer.Deserialize<AccountPackage>(receive);
                                clientModel.UpdateAccount(accountPackage.SendList.GetAccountByIndex(0));
                                break;
                            case InformationType.FRIEND:
                                var friendPackage = JsonSerializer.Deserialize<FriendPackage>(receive);
                                clientModel.UpdateFriendList(friendPackage.SendList);
                                break;
                            case InformationType.ERROR:
                                var errorPackage = JsonSerializer.Deserialize<ErrorPackage>(receive);
                                receiveMessage = errorPackage.GetKeyword();
                                isReceive = true;
                                break;
                            case InformationType.LOGIN:
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Wrong deserialize: " + receive + " [Exception]" + e.Message);
                        break;
                    }
                }
            }
        }
    }
}