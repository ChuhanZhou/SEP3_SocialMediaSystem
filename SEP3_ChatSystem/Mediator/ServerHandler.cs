using System;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using SEP3_ChatSystem.Data;
using SEP3_ChatSystem.Mediator.Information;
using SEP3_ChatSystem.Model.List.Group;
using SEP3_ChatSystem.Model.Unit.Message;

namespace SEP3_ChatSystem.Mediator
{
    public class ServerHandler
    {
        private IChatModel chatModel;
        private TcpClient client;
        private NetworkStream stream;
        private string userId;
        private bool connect;
        private bool sending;
        private bool receiving;
        public ServerHandler(IChatModel chatModel,TcpClient client)
        {
            this.chatModel = chatModel;
            this.chatModel.AddHandler(this);
            this.client = client;
            stream = client.GetStream();
            userId = "Unknown";
            connect = false;
            sending = false;
            receiving = false;
            new Thread(async ()=>await AfterConnect()).Start();
        }

        private void Disconnect()
        {
            stream.Close();
            client.Close();
            connect = false;
            Console.WriteLine("Disconnect with [" + userId + "].");
            chatModel.RemoveHandler(this);
        }

        public string GetId()
        {
            return userId;
        }
        
        private void Send(string information)
        {
            while (sending)
            {
                Thread.Sleep(100);
            }
            sending = true;
            try
            {
                if (!chatModel.DatabaseSystemIsOnline()&&connect)
                {
                    information = JsonSerializer.Serialize(new ErrorPackage("Database System offline.",true));
                }
            
                byte[] dataToClient = Encoding.ASCII.GetBytes(information);

                string length = "";
                for (int i = 0; i < 10-Encoding.ASCII.GetBytes(""+dataToClient.Length).Length; i++)
                {
                    length += "0";
                }
                length += dataToClient.Length;
            
                byte[] dataLength = Encoding.ASCII.GetBytes(length);
                Console.WriteLine("Send Package Length ["+userId+"]:"+length);
                stream.Write(dataLength, 0, dataLength.Length);
            
                Console.WriteLine("Send to ["+userId+"]:"+information);
                stream.Write(dataToClient, 0, dataToClient.Length);
                sending = false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Disconnect [Exception]" + e.Message);
                Disconnect();
                sending = false;
            }
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
                Console.WriteLine("Receive Package Length [" + userId + "]: " + length + "bytes");

                byte[] dataFromServer = new byte[length];
                bytesRead = stream.Read(dataFromServer, 0, dataFromServer.Length);
                receive = Encoding.ASCII.GetString(dataFromServer, 0, bytesRead);
                Console.WriteLine("Receive from [" + userId + "]:" + receive);
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
        
        private void SendErrorPackage(ErrorPackage sendPackage)
        {
            string send = JsonSerializer.Serialize(sendPackage);
            Send(send);
        }
        
        private void SendErrorPackage()
        {
            SendErrorPackage(new ErrorPackage(null,false));
        }

        private void SendErrorPackage(string error)
        {
            if (error==null)
            {
                SendErrorPackage();
            }
            else
            {
                Console.WriteLine("Error:"+error);
                SendErrorPackage(new ErrorPackage(error,true));
            }
        }

        private void SendPrivateMessagePackage(PrivateMessagePackage sendPackage)
        {
            string send = JsonSerializer.Serialize(sendPackage);
            Send(send);
        }
        
        private void SendGroupMessagePackage(GroupMessagePackage sendPackage)
        {
            string send = JsonSerializer.Serialize(sendPackage);
            Send(send);
        }
        
        private void SendChatGroupPackage(ChatGroupPackage sendPackage)
        {
            string send = JsonSerializer.Serialize(sendPackage);
            Send(send);
        }

        private async Task AfterConnect()
        {
            userId = GetReceive();
            SendChatGroupPackage(new ChatGroupPackage(await chatModel.GetChatGroupByUserId(userId),"init"));
            SendPrivateMessagePackage(new PrivateMessagePackage(await chatModel.GetPrivateMessageById(userId),"init"));
            SendGroupMessagePackage(new GroupMessagePackage(await chatModel.GetGroupMessageByUserId(userId),"init"));
            connect = true;
            while (connect)
            {
                string receive = GetReceive();
                if (receive!=null)
                {
                    var receivePackage = JsonSerializer.Deserialize<InformationPackage>(receive);
                    string result = null;
                    switch (receivePackage.informationType)
                    {
                        case InformationType.PRIVATE_MESSAGE:
                            PrivateMessagePackage privateMessagePackage = JsonSerializer.Deserialize<PrivateMessagePackage>(receive);
                            foreach (var message in privateMessagePackage.SendList.MessageList)
                            {
                                result = chatModel.AddNewPrivateMessage(message);
                                if (!string.IsNullOrEmpty(result))
                                {
                                    break;
                                }
                            }
                            break;
                        case InformationType.GROUP_MESSAGE:
                            GroupMessagePackage groupMessagePackage = JsonSerializer.Deserialize<GroupMessagePackage>(receive); 
                            foreach (var message in groupMessagePackage.SendList.MessageList)
                            {
                                result = chatModel.AddNewGroupMessage(message);
                                if (!string.IsNullOrEmpty(result))
                                {
                                    break;
                                }
                            }
                            break;
                        case InformationType.CHAT_GROUP:
                            ChatGroupPackage chatGroupPackage = JsonSerializer.Deserialize<ChatGroupPackage>(receive);
                            switch (chatGroupPackage.Keyword)
                            {
                                case "Add":
                                    result = await chatModel.AddNewGroup(chatGroupPackage.SendList.GetGroupByIndex(0),userId);
                                    break;
                                case "Update":
                                    result = await chatModel.UpdateGroup(chatGroupPackage.SendList.GetGroupByIndex(0), userId);
                                    break;
                                case "AddUser":
                                    result = await chatModel.AddNewGroupMember(chatGroupPackage.SendList.GetGroupByIndex(0).GroupId, chatGroupPackage.TargetId,userId);
                                    break;
                                case "RemoveUser":
                                    result = await chatModel.RemoveGroupMember(chatGroupPackage.SendList.GetGroupByIndex(0).GroupId,chatGroupPackage.TargetId,userId);
                                    break;
                                case "Remove":
                                    result = await chatModel.RemoveGroup(chatGroupPackage.SendList.GetGroupByIndex(0), userId);
                                    break;
                            }
                            break;
                        default:
                            result = "Wrong package.";
                            break;
                    }
                    SendErrorPackage(result);
                }
            }
        }
        
        public async Task UpdateChatGroup()
        {
            ChatGroupList chatGroupList = await chatModel.GetChatGroupByUserId(userId);
            SendChatGroupPackage(new ChatGroupPackage(chatGroupList,"update"));
        }

        public void NewMessage(Message message)
        {
            switch (message.MessageType)
            {
                case MessageType.PRIVATE:
                    SendPrivateMessagePackage(new PrivateMessagePackage((PrivateMessage)message,"update"));
                    break;
                case MessageType.GROUP:
                    SendGroupMessagePackage(new GroupMessagePackage((GroupMessage)message,"update"));
                    break;
            }
        }

        public async Task DatabaseOnline()
        {
            SendChatGroupPackage(new ChatGroupPackage(await chatModel.GetChatGroupByUserId(userId),"init"));
            SendPrivateMessagePackage(new PrivateMessagePackage(await chatModel.GetPrivateMessageById(userId),"init"));
            SendGroupMessagePackage(new GroupMessagePackage(await chatModel.GetGroupMessageByUserId(userId),"init"));
        }
    }
}