using System.Threading.Tasks;
using SEP3_PostSystem.Model.List.PostList;
using SEP3_PostSystem.Model.Unit.Post;

namespace SEP3_PostSystem.Database
{
    public interface ICloudDatabase
    {
        Task<string> AddPost(Post post);
        Task<PostList> GetAllPost();
        Task<string> UpdatePost(Post post);
        Task<string> RemovePost(string postId);
    }
}