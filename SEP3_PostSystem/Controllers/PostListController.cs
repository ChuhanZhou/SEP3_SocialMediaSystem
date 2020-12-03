using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEP3_PostSystem.Data;
using SEP3_PostSystem.Model.List.PostList;
using SEP3_PostSystem.Model.Unit.Post;

namespace SEP3_PostSystem.Controllers
{
    [ApiController]
    [Route("api/post")]
    
    public class PostListController : ControllerBase
    {
        private IPostModel postModel;

        public PostListController()
        {
            postModel = PostModel.GetPostModel();
        }
        
        [HttpPost]
        public async Task<ActionResult<string>> AddPost([FromBody] Post newPost,[FromHeader] string userId)
        {
            try
            {
                return await postModel.AddPost(newPost, userId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<PostList>> GetPost([FromHeader] string userId)
        {
            try
            {
                return await postModel.GetPostToShowByUserId(userId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}