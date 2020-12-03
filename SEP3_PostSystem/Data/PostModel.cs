using SEP3_PostSystem.Model.List.PostList;
using SEP3_PostSystem.UserSystem;

namespace SEP3_PostSystem.Data
{
    public class PostModel
    {
        private static PostModel postModel;
        private PostList postList;
        private ICloudUserSystem cloudUserSystem;

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
        }
    }
}