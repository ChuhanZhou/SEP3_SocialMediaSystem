using System;
using System.Collections.Generic;
using System.Linq;
using SEP3_PostSystem.Model.Unit.Time;
using SEP3_PostSystem.Model.List.PostList;

namespace SEP3_PostSystem.Model.Unit.Post
{
    public class Post
    {
        public MyTime Time { get; set; }
        public string PostId { get; set; }
        public string SenderId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public List<string> LikerIdList { get; set; }
        public CommentList CommentList { get; set; }
        public List<string> DisableList { get; set; }

        public Post(string senderId, string title, string body,List<string> disableList)
        {
            SenderId = senderId;
            Title = title;
            Body = body;
            LikerIdList = new List<string>();
            CommentList = new CommentList();
            DisableList = new List<string>(disableList);
        }

        public Post(string postId, Post post)
        {
            PostId = postId;
            SenderId = post.SenderId;
            Title = post.Title;
            Body = post.Body;
            Time = new MyTime(DateTime.Now);
            LikerIdList = new List<string>();
            CommentList = new CommentList();
            DisableList = new List<string>(post.DisableList);
        }

        public Post(Post post)
        {
            PostId = post.PostId;
            SenderId = post.SenderId;
            Title = post.Title;
            Body = post.Body;
            Time = post.Time.Copy();
            LikerIdList = new List<string>(post.LikerIdList);
            CommentList = post.CommentList.Copy();
            DisableList = new List<string>(post.DisableList);
        }
        
        public Post(){}

        public bool IsLiker(string id)
        {
            return LikerIdList.Any(likerId => likerId==id);
        }

        public bool IsDisable(string id)
        {
            return DisableList.Any(disableId => disableId==id);
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

        public string UpdateByPost(Post post)
        {
            if (PostId==post.PostId&&SenderId==post.SenderId)
            {
                Title = post.Title;
                Body = post.Body;
                DisableList = new List<string>(post.DisableList);
            }
            return "Wrong update.";
        }

        public Post Copy()
        {
            return new Post(this);
        }
    }
}