﻿using System;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using SEP3_Client.Data;
using SEP3_Client.Mediator.Information;
using SEP3_Client.Model;
using SEP3_Client.Model.List.Message;
using SEP3_Client.Model.Unit.Group;
using SEP3_Client.Model.Unit.Message;

namespace SEP3_Client.Mediator.ChatSystemClient
{
    public class ChatSystemClient : IChatSystemClient
    {
        private IClientModelForChatSystem clientModel;
        private static readonly int PORT = 3010;
        private static readonly string HOST = "localhost";
        private int port;
        private string host;

        private TcpClient client;
        private NetworkStream stream;
        private bool login;
        private bool sending;
        private bool receiving;
        private bool isReceive;
        private string receiveMessage;

        public ChatSystemClient() : this(PORT, HOST)
        {
        }

        public ChatSystemClient(int port) : this(port, HOST)
        {
        }

        public ChatSystemClient(string host) : this(PORT, host)
        {
        }

        public ChatSystemClient(int port, string host)
        {
            this.port = port;
            this.host = host;
        }

        private void Send(string information)
        {
            while (sending)
            {
                Thread.Sleep(100);
            }

            sending = true;

            byte[] dataToClient = Encoding.ASCII.GetBytes(information);

            string length = "";
            for (int i = 0; i < 10 - Encoding.ASCII.GetBytes("" + dataToClient.Length).Length; i++)
            {
                length += "0";
            }

            length += dataToClient.Length;

            byte[] dataLength = Encoding.ASCII.GetBytes(length);
            Console.WriteLine("Send Package Length:" + length);
            stream.Write(dataLength, 0, dataLength.Length);

            Console.WriteLine("Send:" + information);
            stream.Write(dataToClient, 0, dataToClient.Length);
            sending = false;
        }

        private string GetReceive()
        {
            while (receiving)
            {
                Thread.Sleep(100);
            }

            receiving = true;

            try
            {
                byte[] packageLength = new byte[10];
                int bytesRead = stream.Read(packageLength, 0, packageLength.Length);
                string receive = Encoding.ASCII.GetString(packageLength, 0, bytesRead);
                int length = Convert.ToInt32(receive);
                Console.WriteLine("Receive Package Length: " + length + "bytes");

                byte[] dataFromServer = new byte[length];
                bytesRead = stream.Read(dataFromServer, 0, dataFromServer.Length);
                receive = Encoding.ASCII.GetString(dataFromServer, 0, bytesRead);
                Console.WriteLine("Receive:" + receive);
                receiving = false;
                return receive;
            }
            catch (Exception e)
            {
                Console.WriteLine("Disconnect [Exception]" + e.Message);
                Disconnect();
                receiving = false;
                return null;
            }
        }

        public bool Connect(IClientModelForChatSystem clientModel)
        {
            Console.WriteLine("Starting client...");
            try
            {
                client = new TcpClient(host, port);
                stream = client.GetStream();
                login = false;
                this.clientModel = clientModel;
                this.clientModel.SystemOnLine(FunctionType.ChatSystem);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Can't connect ChatSystem [Exception]" + e.Message);
                //Console.WriteLine(e);
                return false;
            }
        }

        public void Disconnect()
        {
            stream.Close();
            client.Close();
            login = false;
            clientModel.SystemOffLine(FunctionType.ChatSystem);
        }

        public void Login()
        {
            if (clientModel.HasFunction(FunctionType.ChatSystem))
            {
                try
                {
                    Send(clientModel.GetAccount().Id);
                    ChatGroupPackage chatGroupPackage = JsonSerializer.Deserialize<ChatGroupPackage>(GetReceive());
                    PrivateMessagePackage privateMessagePackage = JsonSerializer.Deserialize<PrivateMessagePackage>(GetReceive());
                    GroupMessagePackage groupMessagePackage = JsonSerializer.Deserialize<GroupMessagePackage>(GetReceive());
                    clientModel.UpdateChatGroupList(chatGroupPackage.SendList);
                    clientModel.UpdatePrivateMessageList(privateMessagePackage.SendList);
                    clientModel.UpdateGroupMessageList(groupMessagePackage.SendList);
                    login = true;
                    new Thread(Start).Start();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Disconnect();
                    throw;
                }
            }
        }
        
        public string SendChatGroupPackage(ChatGroup chatGroup, string targetId, string keyword)
        {
            if (clientModel.HasFunction(FunctionType.ChatSystem))
            {
                while (sending)
                {
                    Thread.Sleep(100);
                }

                sending = true;
                isReceive = false;
                ChatGroupPackage sendPackage = new ChatGroupPackage(chatGroup, targetId, keyword);
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
                return "Chat System offline.";
            }
        }

        public string SendPrivateMessagePackage(PrivateMessageList privateMessageList)
        {
            if (clientModel.HasFunction(FunctionType.ChatSystem))
            {
                while (sending)
                {
                    Thread.Sleep(100);
                }

                sending = true;
                isReceive = false;
                PrivateMessagePackage sendPackage = new PrivateMessagePackage(privateMessageList, null);
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
                return "Chat System offline.";
            }
        }

        public string SendPrivateMessagePackage(PrivateMessage privateMessage)
        {
            if (clientModel.HasFunction(FunctionType.ChatSystem))
            {
                while (sending)
                {
                    Thread.Sleep(100);
                }

                sending = true;
                isReceive = false;
                PrivateMessagePackage sendPackage = new PrivateMessagePackage(privateMessage, null);
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
                return "Chat System offline.";
            }
        }

        public string SendGroupMessagePackage(GroupMessageList groupMessageList)
        {
            if (clientModel.HasFunction(FunctionType.ChatSystem))
            {
                while (sending)
                {
                    Thread.Sleep(100);
                }

                sending = true;
                isReceive = false;
                GroupMessagePackage sendPackage = new GroupMessagePackage(groupMessageList, null);
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
                return "Chat System offline.";
            }
        }

        public string SendGroupMessagePackage(GroupMessage groupMessage)
        {
            if (clientModel.HasFunction(FunctionType.ChatSystem))
            {
                while (sending)
                {
                    Thread.Sleep(100);
                }

                sending = true;
                isReceive = false;
                GroupMessagePackage sendPackage = new GroupMessagePackage(groupMessage, null);
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
                return "Chat System offline.";
            }
        }

        private void Start()
        {
            while (clientModel.HasFunction(FunctionType.ChatSystem))
            {
                while (login)
                {
                    var receive = GetReceive();
                    try
                    {
                        var informationPackage = JsonSerializer.Deserialize<InformationPackage>(receive);
                        switch (informationPackage.GetInformationType())
                        {
                            case InformationType.PRIVATE_MESSAGE:
                                var privateMessagePackage = JsonSerializer.Deserialize<PrivateMessagePackage>(receive);
                                switch (privateMessagePackage.Keyword)
                                {
                                    case "init":
                                        clientModel.UpdatePrivateMessageList(privateMessagePackage.SendList);
                                        break;
                                    case "update":
                                        clientModel.AddPrivateMessage(
                                            privateMessagePackage.SendList.GetMessageByIndex(0));
                                        break;
                                }
                                break;
                            case InformationType.GROUP_MESSAGE:
                                var groupMessagePackage = JsonSerializer.Deserialize<GroupMessagePackage>(receive);
                                switch (groupMessagePackage.Keyword)
                                {
                                    case "init":
                                        clientModel.UpdateGroupMessageList(groupMessagePackage.SendList);
                                        break;
                                    case "update":
                                        clientModel.AddGroupMessage(groupMessagePackage.SendList.GetMessageByIndex(0));
                                        break;
                                }
                                clientModel.UpdateGroupMessageList(groupMessagePackage.SendList);
                                break;
                            case InformationType.CHAT_GROUP:
                                var chatGroupPackage = JsonSerializer.Deserialize<ChatGroupPackage>(receive);
                                clientModel.UpdateChatGroupList(chatGroupPackage.SendList);
                                break;
                            case InformationType.ERROR:
                                var errorPackage = JsonSerializer.Deserialize<ErrorPackage>(receive);
                                receiveMessage = errorPackage.GetKeyword();
                                isReceive = true;
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