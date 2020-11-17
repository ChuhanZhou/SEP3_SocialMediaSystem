namespace SEP3_Client.Model.Unit.User
{
    public class FriendSetting : User
    {
        public string Note { get; set; }
        public bool DisablePost { get; set; }
        public FriendSettingStatus Status { get; set; }
        
        public FriendSetting(string id,string note,bool disablePost) : base(id)
        {
            DisablePost = disablePost;
            if (string.IsNullOrEmpty(note))
            {
                Note = "";
            }
            else
            {
                Note = note;
            }
            Status = FriendSettingStatus.UNCONFIRMED;
        }

        private FriendSetting(string id,string note,bool disablePost,FriendSettingStatus status) : this(id,note,disablePost)
        {
            Status = status;
        }
        
        public FriendSetting(string id) : base(id)
        {
            DisablePost = false;
            Note = null;
            Status = FriendSettingStatus.UNCONFIRMED;
        }
        
        public FriendSetting(){}

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
            if (Status == FriendSettingStatus.UNCONFIRMED)
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
            if (Status==FriendSettingStatus.UNCONFIRMED&&Note==null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool WaitAgree()
        {
            if (Status==FriendSettingStatus.UNCONFIRMED&&Note!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsConfirmed()
        {
            if (Status==FriendSettingStatus.AGREE||Status==FriendSettingStatus.DISAGREE)
            {
                return true;
            }
            else
            {
                return false;
            }
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