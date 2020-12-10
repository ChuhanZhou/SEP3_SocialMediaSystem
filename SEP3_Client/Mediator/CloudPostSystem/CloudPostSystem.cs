using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SEP3_Client.Data;
using SEP3_Client.Model;
using SEP3_Client.Model.List.PostList;
using SEP3_Client.Model.Unit.Post;

namespace SEP3_Client.Mediator.CloudPostSystem
{
    public class CloudPostSystem : ICloudPostSystem
    {
        private HttpClient client;
        private const string uri = "https://localhost:7001/api/";
        private IClientModelForPostSystem clientModel;

        public CloudPostSystem(ClientModelManager clientModel)
        {
            client = new HttpClient();
            this.clientModel = clientModel;
        }
        
        public async Task<string> AddPost(Post post, string userId)
        {
            try
            {
                var newPostJson = JsonSerializer.Serialize(post);
                HttpContent httpContent = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                var message = await client.PostAsync(uri + "post?userId="+userId, httpContent);
                Console.WriteLine("Post send: " + newPostJson);
                var result = await message.Content.ReadAsStringAsync();
                Console.WriteLine("Post receive: " + result);
                Console.WriteLine("Post end");
                clientModel.SystemOnLine(FunctionType.PostSystem);
                return result;
            }
            catch (Exception e)
            {
                clientModel.SystemOffLine(FunctionType.PostSystem);
                return "Post system offline.";
            }
        }

        public async Task<PostList> GetPost(string userId)
        {
            try
            {
                var message = await client.GetStringAsync(uri + "post?userId=" + userId);
                Console.WriteLine("Get Receive: " + message);
                var postList = JsonSerializer.Deserialize<PostList>(message);
                Console.WriteLine("Get end");
                clientModel.SystemOnLine(FunctionType.PostSystem);
                return postList;
            }
            catch (Exception e)
            {
                clientModel.SystemOffLine(FunctionType.PostSystem);
                return new PostList();
            }
        }

        public async Task<string> UpdatePostLike(string postId, string userId)
        {
            try
            {
                var message = await client.PutAsync(uri + "post/like?postId=" + postId + "&userId=" + userId, null);
                Console.WriteLine("Put send: " + uri + "post/like?postId=" + postId + "&userId=" + userId);
                var result = await message.Content.ReadAsStringAsync();
                Console.WriteLine("Put receive: " + result);
                Console.WriteLine("Put end");
                clientModel.SystemOnLine(FunctionType.PostSystem);
                return result;
            }
            catch (Exception e)
            {
                clientModel.SystemOffLine(FunctionType.PostSystem);
                return "Post system offline.";
            }
        }

        public async Task<string> AddComment(string postId, Comment comment, string userId)
        {
            try
            {
                var newCommentJson = JsonSerializer.Serialize(comment);
                HttpContent httpContent = new StringContent(newCommentJson, Encoding.UTF8, "application/json");
                var message = await client.PostAsync(uri + "post/comment?postId=" + postId + "&userId=" + userId, httpContent);
                Console.WriteLine("Post send: " + newCommentJson);
                var result = await message.Content.ReadAsStringAsync();
                Console.WriteLine("Post receive: " + result);
                Console.WriteLine("Post end");
                clientModel.SystemOnLine(FunctionType.PostSystem);
                return result;
            }
            catch (Exception e)
            {
                clientModel.SystemOffLine(FunctionType.PostSystem);
                return "Post system offline.";
            }
        }

        public async Task<string> RemoveComment(string postId, string commentId, string userId)
        {
            try
            {
                var message = await client.DeleteAsync(uri + "post/comment?postId=" + postId + "&commentId=" + commentId + "&userId=" + userId);
                Console.WriteLine("Delete send: " + uri + "post/comment?postId=" + postId + "&commentId=" + commentId + "&userId=" + userId);
                var result = await message.Content.ReadAsStringAsync();
                Console.WriteLine("Delete receive: " + result);
                Console.WriteLine("Delete end");
                clientModel.SystemOnLine(FunctionType.PostSystem);
                return result;
            }
            catch (Exception e)
            {
                clientModel.SystemOffLine(FunctionType.PostSystem);
                return "Post system offline.";
            }
        }

        public async Task<string> UpdatePostBySender(Post newPost, string userId)
        {
            try
            {
                var newPostJson = JsonSerializer.Serialize(newPost);
                HttpContent httpContent = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                var message = await client.PutAsync(uri + "post?userId=" + userId, httpContent);
                Console.WriteLine("Put send: " + newPostJson);
                var result = await message.Content.ReadAsStringAsync();
                Console.WriteLine("Put receive: " + result);
                Console.WriteLine("Put end");
                clientModel.SystemOnLine(FunctionType.PostSystem);
                return result;
            }
            catch (Exception e)
            {
                clientModel.SystemOffLine(FunctionType.PostSystem);
                return "Post system offline.";
            }
        }

        public async Task RemovePost(string postId, string userId)
        {
            try
            {
                await client.DeleteAsync(uri + "post?postId=" + postId + "&userId=" + userId);
                Console.WriteLine("Delete send: " + uri + "post?postId=" + postId + "&userId=" + userId);
                Console.WriteLine("Delete end");
                clientModel.SystemOnLine(FunctionType.PostSystem);
            }
            catch (Exception e)
            {
                clientModel.SystemOffLine(FunctionType.PostSystem);
            }
        }
    }
}