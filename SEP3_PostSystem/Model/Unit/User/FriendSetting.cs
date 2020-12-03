namespace SEP3_PostSystem.Model.Unit.User
{
    public class FriendSetting : User
    {
        public string Note { get; set; }
        public bool DisablePost { get; set; }
        public FriendSettingStatus Status { get; set; }
        
        public FriendSetting(string id,string note,bool disablePost) : base(id)
        {
            DisablePost = disablePost;
            Note = note;
            Status = FriendSettingStatus.WAITAGREE;
        }

        private FriendSetting(string id,string note,bool disablePost,FriendSettingStatus status) : this(id,note,disablePost)
        {
            Status = status;
        }
        
        public FriendSetting(string id) : base(id)
        {
            DisablePost = false;
            Note = null;
            Status = FriendSettingStatus.NEEDAGREE;
        }
        
        public FriendSetting(){}
        
        public bool Unconfirmed()
        {
            return Status==FriendSettingStatus.WAITAGREE||Status==FriendSettingStatus.NEEDAGREE;
        }

        public string GetNote() 
        {
            return Note;
        }

        public bool IsDisablePost() 
        {
            return DisablePost;
        }
        
        public FriendSettingStatus GetStatus() {
            return Status;
        }

        public void SetNote(string note) 
        {
            Note = note;
        }

        public void SetDisablePost(bool disablePost) 
        {
            DisablePost = disablePost;
        }
        
        public void SetStatus(bool agree) {
            if (Unconfirmed())
            {
                if (agree)
                {
                    Status = FriendSettingStatus.AGREE;
                }
                else
                {
                    Status = FriendSettingStatus.DISAGREE;
                }
            }
        }

        public bool NeedAgree()
        {
            return Status== FriendSettingStatus.NEEDAGREE;
        }
        
        public bool WaitAgree()
        {
            return Status== FriendSettingStatus.WAITAGREE;
        }

        public bool IsConfirmed()
        {
            return Status == FriendSettingStatus.AGREE || Status == FriendSettingStatus.DISAGREE;
        }
        
        public void Delete()
        {
            Status = FriendSettingStatus.DELETE;
        }
        
        public void Update(FriendSetting friendSetting) 
        {
            Note = friendSetting.GetNote();
            DisablePost = friendSetting.IsDisablePost();
            Status = friendSetting.GetStatus();
        }
        
        public FriendSetting Copy() 
        {
            return new FriendSetting(Id,Note,DisablePost,Status);
        }
    }
}