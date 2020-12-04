using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SEP3_Client.Model.List.PostList;
using SEP3_Client.Model.Unit.Post;

namespace SEP3_Client.Mediator.CloudPostSystem
{
    public class CloudPostSystem : ICloudPostSystem
    {
        private HttpClient client;
        private const string uri = "http://localhost:7000/api/";

        public CloudPostSystem()
        {
            client = new HttpClient();
        }
        
        public async Task<string> AddPost(Post post, string userId)
        {
            try
            {
                var newPostJson = JsonSerializer.Serialize(post);
                HttpContent httpContent = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                var message = await client.PostAsync(uri + "post", httpContent);
                Console.WriteLine("Post send: " + newPostJson);
                var result = await message.Content.ReadAsStringAsync();
                Console.WriteLine("Receive: " + result);
                Console.WriteLine("Post end");
                return result;
            }
            catch (Exception e)
            {
                return "Post system offline.";
            }
        }

        public Task<PostList> GetPost(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdatePostLike(string postId, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<string> AddComment(string postId, Comment comment, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<string> RemoveComment(string postId, string commentId, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdatePostBySender(Post newPost, string userId)
        {
            throw new NotImplementedException();
        }

        public Task RemovePost(string postId, string userId)
        {
            throw new NotImplementedException();
        }
    }
}