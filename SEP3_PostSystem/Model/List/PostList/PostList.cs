using System.Collections.Generic;
using System.Linq;
using SEP3_PostSystem.Model.Unit.Post;

namespace SEP3_PostSystem.Model.List.PostList
{
    public class PostList
    {
        public List<Post> Posts { get; set; }
        
        public PostList()
        {
            Posts = new List<Post>();
        }

        public PostList(List<Post> postList)
        {
            Posts = new List<Post>();
            foreach (var post in postList)
            {
                Posts.Add(post.Copy());
            }
        }
        
        public bool HasPostId(string id)
        {
            return Posts.Any(post => post.PostId == id);
        }

        public string AddPost(Post post)
        {
            if (post!=null)
            {
                if (!HasPostId(post.PostId))
                {
                    Posts.Add(post);
                    return null;
                }
                else
                {
                    return "Not a new post.";
                }
            }
            return "Input null.";
        }

        public Post GetPostByPostId(string id)
        {
            return Posts.FirstOrDefault(post => post.PostId == id);
        }
        
        public Post GetPostByIndex(int index)
        {
            if (index>=0&&index<Posts.Count)
            {
                return Posts[index];
            }
            return null;
        }
        
        public PostList GetPostBySenderId(string id)
        {
            var postList = new PostList();
            foreach (var post in Posts.Where(post => post.SenderId==id))
            {
                postList.Posts.Add(post);
            }

            return postList;
        }

        public string UpdatePost(Post newPost)
        {
            var target = GetPostByPostId(newPost.PostId);
            if (target!=null)
            {
                target = new Post(newPost);
                return null;
            }
            return "Not find post.";
        }

        public void RemovePostByPostId(string id)
        {
            foreach (var post in Posts.Where(post => post.PostId==id))
            {
                Posts.Remove(post);
                break;
            }
        }

        public PostList Copy()
        {
            return new PostList(Posts);
        }
    }
}