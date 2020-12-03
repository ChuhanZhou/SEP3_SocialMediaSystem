using System.Threading.Tasks;
using SEP3_PostSystem.Model.List.PostList;
using SEP3_PostSystem.Model.Unit.Post;

namespace SEP3_PostSystem.Data
{
    public interface IPostModel
    {
        Task<string>  AddPost(Post post,string userId);
        Task<PostList> GetPostToShowByUserId(string userId);
        string UpdatePostLike(string postId,string userId);
        string CommentPost(string postId,Comment comment,string userId);
        string RemoveComment(string postId,string commentId,string userId);
        string UpdatePostByReader(Post newPost,string userId);
        void RemovePost(string postId,string userId);
    }
}