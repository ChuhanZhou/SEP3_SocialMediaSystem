namespace SEP3_Client.Model.Unit.User
{
    public class FriendSetting : User
    {
        public string Note { get; set; }
        public bool DisablePost { get; set; }
        public FriendSettingState State { get; set; }
        
        public FriendSetting(string id,string note,bool disablePost) : base(id)
        {
            DisablePost = disablePost;
            Note = note;
            State = FriendSettingState.UNCONFIRMED;
        }

        private FriendSetting(string id,string note,bool disablePost,FriendSettingState state) : this(id,note,disablePost)
        {
            State = state;
        }

        public string GetNote() 
        {
            return Note;
        }

        public bool IsDisablePost() 
        {
            return DisablePost;
        }
        
        public FriendSettingState GetState() {
            return State;
        }

        public void SetNote(string note) 
        {
            Note = note;
        }

        public void SetDisablePost(bool disablePost) 
        {
            DisablePost = disablePost;
        }
        
        public void SetState(bool agree) {
            if (State == FriendSettingState.UNCONFIRMED)
            {
                if (agree)
                {
                    State = FriendSettingState.AGREE;
                }
                else
                {
                    State = FriendSettingState.DISAGREE;
                }
            }
        }

        public void Update(FriendSetting friendSetting) 
        {
            Note = friendSetting.GetNote();
            DisablePost = friendSetting.IsDisablePost();
        }
        
        public FriendSetting Copy() 
        {
            return new FriendSetting(Id,Note,DisablePost,State);
        }
    }
}