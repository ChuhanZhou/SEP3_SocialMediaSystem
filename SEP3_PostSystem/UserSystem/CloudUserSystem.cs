using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using SEP3_PostSystem.Model.List.UserList;

namespace SEP3_PostSystem.UserSystem
{
    public class CloudUserSystem : ICloudUserSystem
    {
        private HttpClient client;
        private const string uri = "http://localhost:8050/api/";
        
        public CloudUserSystem()
        {
            client = new HttpClient();
        }
        
        public async Task<FriendList> GetFriendListByUserId(string id)
        {
            try
            {
                var message = await client.GetStringAsync(uri + "friend?userId="+id);
                Console.WriteLine("Get Receive: " + message);
                var friendList = JsonSerializer.Deserialize<FriendList>(message);
                Console.WriteLine("Get end");
                return friendList;
            }
            catch (Exception e)
            {
                return new FriendList();
            }
        }
    }
}