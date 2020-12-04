using System.Threading.Tasks;
using SEP3_PostSystem.Model.List.PostList;
using SEP3_PostSystem.Model.Unit.Post;

namespace SEP3_PostSystem.Database
{
    public class CloudDatabase : ICloudDatabase
    {
        public Task<string> AddPost(Post post)
        {
            throw new System.NotImplementedException();
        }

        public Task<PostList> GetAllPost()
        {
            throw new System.NotImplementedException();
        }

        public Task<string> UpdatePost(Post post)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> RemovePost(string postId)
        {
            throw new System.NotImplementedException();
        }
    }
}