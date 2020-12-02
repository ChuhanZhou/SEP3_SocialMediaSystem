namespace SEP3_PostSystem.Model.Unit.Post
{
    public class Comment
    {
        public string CommentId { get; set; }
        public string SenderId { get; set; }
        public string CommentBody { get; set; }

        public Comment(string senderId,string commentBody)
        {
            SenderId = senderId;
            CommentBody = commentBody;
        }

        public Comment(string commentId, Comment comment)
        {
            CommentId = commentId;
            SenderId = comment.SenderId;
            CommentBody = comment.CommentBody;
        }
        
        public Comment(){}

        public Comment Copy()
        {
            return new Comment(CommentId,this);
        }
    }
}