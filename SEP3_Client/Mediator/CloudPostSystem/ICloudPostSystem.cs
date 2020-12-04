using System.Threading.Tasks;
using SEP3_Client.Model.List.PostList;
using SEP3_Client.Model.Unit.Post;

namespace SEP3_Client.Mediator.CloudPostSystem
{
    public interface ICloudPostSystem
    {
        Task<string> AddPost(Post post, string userId);
        Task<PostList> GetPost(string userId);
        Task<string> UpdatePostLike(string postId,string userId);
        Task<string> AddComment(string postId,Comment comment,string userId);
        Task<string> RemoveComment(string postId,string commentId,string userId);
        Task<string> UpdatePostBySender(Post newPost,string userId);
        Task RemovePost(string postId,string userId);
    }
}