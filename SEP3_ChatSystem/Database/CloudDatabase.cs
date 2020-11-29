using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SEP3_ChatSystem.Data;
using SEP3_ChatSystem.Model.List.Group;
using SEP3_ChatSystem.Model.List.Message;
using SEP3_ChatSystem.Model.Unit.Group;
using SEP3_ChatSystem.Model.Unit.Message;

namespace SEP3_ChatSystem.Database
{
    public class CloudDatabase : ICloudDatabase
    {
        private HttpClient client;
        private const string uri = "http://localhost:8070/api/";
        private IChatModelForDatabase chatModel;

        public CloudDatabase(IChatModelForDatabase chatModel)
        {
            client = new HttpClient();
            this.chatModel = chatModel;
        }
        
        public async Task AddChatGroup(ChatGroup chatGroup)
        {
            try
            {
                var newChatGroupJson = JsonSerializer.Serialize(chatGroup);
                HttpContent httpContent = new StringContent(newChatGroupJson, Encoding.UTF8, "application/json");
                var message = await client.PostAsync(uri + "chatGroup", httpContent);
                Console.WriteLine("Post send: " + newChatGroupJson);
                var result = await message.Content.ReadAsStringAsync();
                Console.WriteLine("API Part Receive: " + result);
                await chatModel.DatabaseSystemOnline();
            }
            catch (Exception e)
            {
                chatModel.DatabaseSystemOffline();
            }
            Console.WriteLine("Post end");
        }

        public async Task<ChatGroupList> GetAllChatGroup()
        {
            try
            {
                var message = await client.GetStringAsync(uri + "chatGroup");
                Console.WriteLine("Get Receive: " + message);
                var chatGroupList = JsonSerializer.Deserialize<ChatGroupList>(message);
                await chatModel.DatabaseSystemOnline();
                Console.WriteLine("Get end");
                return chatGroupList;
            }
            catch (Exception e)
            {
                chatModel.DatabaseSystemOffline();
            }
            return new ChatGroupList();
        }

        public async Task UpdateChatGroup(ChatGroup chatGroup)
        {
            try
            {
                var newChatGroupJson = JsonSerializer.Serialize(chatGroup);
                HttpContent httpContent = new StringContent(newChatGroupJson, Encoding.UTF8, "application/json");
                var message = await client.PutAsync(uri + "chatGroup", httpContent);
                Console.WriteLine("Put send: " + newChatGroupJson);
                var result = await message.Content.ReadAsStringAsync();
                Console.WriteLine("API Part Receive: " + result);
                await chatModel.DatabaseSystemOnline();
            }
            catch (Exception e)
            {
                chatModel.DatabaseSystemOffline();
            }
            Console.WriteLine("Put end");
        }

        public async Task RemoveChatGroup(ChatGroup chatGroup)
        {
            try
            {
                await client.DeleteAsync(uri + "chatGroup?chatGroupId="+chatGroup.GroupId);
                Console.WriteLine("Delete: "+chatGroup.GroupId);
                await chatModel.DatabaseSystemOnline();
            }
            catch (Exception e)
            {
                chatModel.DatabaseSystemOffline();
            }
            Console.WriteLine("Delete end");
        }

        public async Task AddPrivateMessage(PrivateMessage privateMessage)
        {
            try
            {
                var newPrivateMessageJson = JsonSerializer.Serialize(privateMessage);
                HttpContent httpContent = new StringContent(newPrivateMessageJson, Encoding.UTF8, "application/json");
                var message = await client.PostAsync(uri + "privateMessage", httpContent);
                Console.WriteLine("Post send: " + newPrivateMessageJson);
                var result = await message.Content.ReadAsStringAsync();
                Console.WriteLine("API Part Receive: " + result);
                await chatModel.DatabaseSystemOnline();
            }
            catch (Exception e)
            {
                chatModel.DatabaseSystemOffline();
            }
            Console.WriteLine("Post end");
        }

        public async Task<PrivateMessageList> GetAllPrivateMessage()
        {
            try
            {
                var message = await client.GetStringAsync(uri + "privateMessage");
                Console.WriteLine("Get Receive: " + message);
                var chatGroupList = JsonSerializer.Deserialize<PrivateMessageList>(message);
                await chatModel.DatabaseSystemOnline();
                Console.WriteLine("Get end");
                return chatGroupList;
            }
            catch (Exception e)
            {
                chatModel.DatabaseSystemOffline();
            }
            return new PrivateMessageList();
        }

        public async Task AddGroupMessage(GroupMessage groupMessage)
        {
            try
            {
                var newGroupMessageJson = JsonSerializer.Serialize(groupMessage);
                HttpContent httpContent = new StringContent(newGroupMessageJson, Encoding.UTF8, "application/json");
                var message = await client.PostAsync(uri + "groupMessage", httpContent);
                Console.WriteLine("Post send: " + newGroupMessageJson);
                var result = await message.Content.ReadAsStringAsync();
                Console.WriteLine("API Part Receive: " + result);
                await chatModel.DatabaseSystemOnline();
            }
            catch (Exception e)
            {
                chatModel.DatabaseSystemOffline();
            }
            Console.WriteLine("Post end");
        }

        public async Task<GroupMessageList> GetAllGroupMessage()
        {
            try
            {
                var message = await client.GetStringAsync(uri + "groupMessage");
                Console.WriteLine("Get Receive: " + message);
                var chatGroupList = JsonSerializer.Deserialize<GroupMessageList>(message);
                await chatModel.DatabaseSystemOnline();
                Console.WriteLine("Get end");
                return chatGroupList;
            }
            catch (Exception e)
            {
                chatModel.DatabaseSystemOffline();
            }
            return new GroupMessageList();
        }
    }
}