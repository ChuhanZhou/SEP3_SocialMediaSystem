using System;
using System.Threading.Tasks;
using SEP3_PostSystem.Database;
using SEP3_PostSystem.Model.List.PostList;
using SEP3_PostSystem.Model.List.UserList;
using SEP3_PostSystem.Model.Unit.Post;
using SEP3_PostSystem.UserSystem;

namespace SEP3_PostSystem.Data
{
    public class PostModel : IPostModel
    {
        private static PostModel postModel;
        private PostList postList;
        private ICloudUserSystem cloudUserSystem;
        private ICloudDatabase cloudDatabase;

        public static PostModel GetPostModel()
        {
            if (postModel==null)
            {
                postModel = new PostModel();
            }

            return postModel;
        }
        
        private PostModel()
        {
            postList = new PostList();
            cloudUserSystem = new CloudUserSystem();
            cloudDatabase = new CloudDatabase();
        }
        
        private static string GetRandomId()
        {
            string randomId = "";
            for (int x=0;x<16;x++)
            {
                randomId += new Random().Next(0, 16).ToString("X");
            }
            return randomId;
        }

        public async Task<string> AddPost(Post post, string userId)
        {
            if (post!=null&&await cloudUserSystem.HasId(userId))
            {
                if (post.SenderId==userId)
                {
                    string newId = GetRandomId();
                    while (postList.HasPostId(newId))
                    {
                        newId = GetRandomId();
                    }
                    var newPost = new Post(newId, post);
                    string result = postList.AddPost(newPost);
                    if (result==null)
                    {
                        return await cloudDatabase.AddPost(newPost);
                    }
                    return result;
                }
            }
            return "Wrong input.";
        }

        public async Task<PostList> GetPostToShowByUserId(string userId)
        {
            PostList searchList = new PostList();
            FriendList friendList = await cloudUserSystem.GetFriendListByUserId(userId);
            foreach (var post in postList.Posts)
            {
                //user's post or friends' post which is not disable user
                if (friendList.GetFriendById(post.SenderId)!=null&&!post.IsDisable(userId)||post.SenderId==userId)
                {
                    searchList.AddPost(post);
                }
            }
            return searchList;
        }

        public async Task<string> UpdatePostLike(string postId, string userId)
        {
            if (postList.HasPostId(postId))
            {
                var post = postList.GetPostByPostId(postId);
                if (post.IsLiker(userId))
                {
                    string result = post.RemoveLiker(postId);
                    if (result==null)
                    {
                        return await cloudDatabase.UpdatePost(post);
                    }
                    return result;
                }
                return post.AddLiker(userId);
            }
            return "Can't find post.";
        }

        public async Task<string> CommentPost(string postId, Comment comment, string userId)
        {
            if (postList.HasPostId(postId))
            {
                if (comment.SenderId == userId)
                {
                    var post = postList.GetPostByPostId(postId);
                    string commentId = GetRandomId();
                    while (post.CommentList.HasCommentId(commentId))
                    {
                        commentId = GetRandomId();
                    }
                    post.CommentList.AddComment(new Comment(postId, comment));
                    return await cloudDatabase.UpdatePost(post);
                }
                return "Wrong sender.";
            }
            return "Can't find post.";
        }

        public async Task<string> RemoveComment(string postId, string commentId, string userId)
        {
            if (!postList.HasPostId(postId)) return "Can't find post.";
            var post = postList.GetPostByPostId(postId);
            if (!post.CommentList.HasCommentId(commentId)) return "Can't find comment.";
            var comment = post.CommentList.GetCommentByCommentId(commentId);
            if (comment.SenderId != userId) return "Wrong user.";
            post.CommentList.RemoveCommentByCommentId(commentId);
            return await cloudDatabase.UpdatePost(post);
        }

        public async Task<string> UpdatePostBySender(Post newPost, string userId)
        {
            if (!postList.HasPostId(newPost.PostId)) return "Can't find post.";
            var post = postList.GetPostByPostId(newPost.PostId);
            if (post.SenderId != userId) return "Wrong user.";
            string result = post.UpdateByPost(newPost);
            if (result==null)
            {
                return await cloudDatabase.UpdatePost(post);
            }
            return result;
        }

        public void RemovePost(string postId, string userId)
        {
            if (postList.HasPostId(postId))
            {
                if (postList.GetPostByPostId(postId).SenderId == userId)
                {
                    postList.RemovePostByPostId(postId);
                    cloudDatabase.RemovePost(postId);
                }
            }
        }
    }
}