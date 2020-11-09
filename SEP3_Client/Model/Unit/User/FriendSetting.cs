namespace SEP3_Client.Model.Unit.User
{
    public class FriendSetting : User
    {
        public string Note { get; set; }
        public bool DisablePost { get; set; }
        
        public FriendSetting(string id,bool disablePost) : base(id)
        {
            DisablePost = disablePost;
        }

        private FriendSetting(string id,bool disablePost,string note) : this(id, disablePost)
        {
            Note = note;
        }

        public string GetNote() 
        {
            return Note;
        }

        public bool IsDisablePost() 
        {
            return DisablePost;
        }

        public void SetNote(string note) 
        {
            Note = note;
        }

        public void SetDisablePost(bool disablePost) 
        {
            DisablePost = disablePost;
        }

        public void Update(FriendSetting friendSetting) 
        {
            Note = friendSetting.GetNote();
            DisablePost = friendSetting.IsDisablePost();
        }
        
        public FriendSetting Copy() 
        {
            return new FriendSetting(Id,DisablePost,Note);
        }
    }
}