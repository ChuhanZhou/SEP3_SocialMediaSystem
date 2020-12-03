using Microsoft.AspNetCore.Mvc;
using SEP3_PostSystem.Data;

namespace SEP3_PostSystem.Controllers
{
    [ApiController]
    [Route("api/post")]
    
    public class PostListController
    {
        private IPostModel postModel;

        public PostListController()
        {
            postModel = PostModel.GetPostModel();
        }
        
        
    }
}