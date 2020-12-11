using System.Collections.Generic;
using System.Linq;
using SEP3_PostSystem.Model.Unit.Post;

namespace SEP3_PostSystem.Model.List.PostList
{
    public class CommentList
    {
        public List<Comment> Comments { get; set; }

        public CommentList()
        {
            Comments = new List<Comment>();
        }

        public CommentList(List<Comment> commentList)
        {
            Comments = new List<Comment>();
            foreach (var comment in commentList)
            {
                Comments.Add(comment.Copy());
            }
        }

        public bool HasCommentId(string id)
        {
            return Comments.Any(comment => comment.CommentId == id);
        }

        public string AddComment(Comment comment)
        {
            if (comment!=null)
            {
                if (!HasCommentId(comment.CommentId))
                {
                    Comments.Add(comment);
                    return null;
                }
                else
                {
                    return "Not a new comment.";
                }
            }
            return "Input null.";
        }

        public Comment GetCommentByCommentId(string id)
        {
            foreach (var comment in Comments)
            {
                if (comment.CommentId==id)
                {
                    return comment;
                }
            }
            return null;
        }

        public Comment GetCommentByIndex(int index)
        {
            if (index>=0&&index<Comments.Count)
            {
                return Comments[index];
            }

            return null;
        }

        public void RemoveCommentByCommentId(string id)
        {
            foreach (var comment in Comments.Where(comment => comment.CommentId==id))
            {
                Comments.Remove(comment);
                break;
            }
        }

        public CommentList Copy()
        {
            return new CommentList(Comments);
        }
    }
}