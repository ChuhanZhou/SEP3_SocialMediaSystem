using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SEP3_PostSystem.Data;
using SEP3_PostSystem.Model.List.PostList;
using SEP3_PostSystem.Model.Unit.Post;

namespace SEP3_PostSystem.Database
{
    public class CloudDatabase : ICloudDatabase
    {
        private HttpClient client;
        private const string uri = "http://localhost:8070/api/";
        private IPostModelForDatabase postModel;

        public CloudDatabase(PostModel postModel)
        {
            client = new HttpClient();
            this.postModel = postModel;
        }
        
        public async Task<string> AddPost(Post post)
        {
            try
            {
                var newPostJson = JsonSerializer.Serialize(post);
                HttpContent httpContent = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                var message = await client.PostAsync(uri + "post", httpContent);
                Console.WriteLine("Post send: " + newPostJson);
                var result = await message.Content.ReadAsStringAsync();
                Console.WriteLine("API Part Receive: " + result);
                Console.WriteLine("Post end");
                postModel.DatabaseSystemOnline();
                return null;
            }
            catch (Exception e)
            {
                postModel.DatabaseSystemOffline();
                return "Data base offline.";
            }
        }

        public async Task<PostList> GetAllPost()
        {
            try
            {
                var message = await client.GetStringAsync(uri + "post");
                Console.WriteLine("Get Receive: " + message);
                var postList = JsonSerializer.Deserialize<PostList>(message);
                Console.WriteLine("Get end");
                postModel.DatabaseSystemOnline();
                return postList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                postModel.DatabaseSystemOffline();
                return new PostList();
            }
        }

        public async Task<string> UpdatePost(Post post)
        {
            try
            {
                var newPostJson = JsonSerializer.Serialize(post);
                HttpContent httpContent = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                var message = await client.PutAsync(uri + "post", httpContent);
                Console.WriteLine("Put send: " + newPostJson);
                var result = await message.Content.ReadAsStringAsync();
                Console.WriteLine("API Part Receive: " + result);
                Console.WriteLine("Put end");
                postModel.DatabaseSystemOnline();
                return null;
            }
            catch (Exception e)
            {
                postModel.DatabaseSystemOffline();
                return "Data base offline.";
            }
            
        }

        public async Task<string> RemovePost(string postId)
        {
            try
            {
                await client.DeleteAsync(uri + "post?postId=" + postId);
                Console.WriteLine("Delete: "+ uri + "post?postId=" + postId); 
                Console.WriteLine("Delete end");
                postModel.DatabaseSystemOnline();
                return null;
            }
            catch (Exception e)
            {
                postModel.DatabaseSystemOffline();
                return "Data base offline.";
            }
        }
    }
}