using System.Collections.Generic;
using System.Linq;
using SEP3_PostSystem.Model.List.Post;

namespace SEP3_PostSystem.Model.Unit.Post
{
    public class Post
    {
        public string PostId { get; set; }
        public string SenderId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public List<string> LikerIdList { get; set; }
        public CommentList CommentList { get; set; }

        public Post(string senderId, string title, string body)
        {
            SenderId = senderId;
            Title = title;
            Body = body;
            LikerIdList = new List<string>();
            CommentList = new CommentList();
        }

        public Post(string postId, Post post)
        {
            PostId = postId;
            SenderId = post.SenderId;
            Title = post.Title;
            Body = post.Body;
            LikerIdList = new List<string>();
            CommentList = new CommentList();
        }

        public Post(Post post)
        {
            PostId = post.PostId;
            SenderId = post.SenderId;
            Title = post.Title;
            Body = post.Body;
            LikerIdList = new List<string>(post.LikerIdList);
            CommentList = post.CommentList.Copy();
        }
        
        public Post(){}

        public bool IsLiker(string id)
        {
            if (LikerIdList.Any(likerId => likerId==id))
            {
                return true;
            }
            return false;
        }

        public string AddLiker(string id)
        {
            if (!IsLiker(id))
            {
                LikerIdList.Add(id);
                return null;
            }
            return "Not a new liker.";
        }
        
        public string RemoveLiker(string id)
        {
            if (IsLiker(id))
            {
                LikerIdList.Remove(id);
                return null;
            }
            return "Not a liker.";
        }

        public Post Copy()
        {
            return new Post(this);
        }
    }
}