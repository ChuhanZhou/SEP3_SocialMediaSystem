using SEP3_PostSystem.Model.List.PostList;
using SEP3_PostSystem.Model.Unit.Post;

namespace SEP3_PostSystem.Data
{
    public interface IPostModel
    {
        string AddPost(Post post);
        PostList GetPostToShowByUserId(string id);
        string UpdatePost(Post post);
        void RemovePost(string postId,string id);
    }
}