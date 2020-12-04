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

        [HttpPut]
        public ActionResult<string> UpdatePost([FromBody] Post newPost, [FromQuery] string userId)
        {
            try
            {
                return postModel.UpdatePostBySender(newPost,userId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpDelete]
        public ActionResult<string> RemovePost([FromHeader] string postId, [FromQuery] string userId)
        {
            try
            {
                postModel.RemovePost(postId,userId);
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        [Route("like")]
        public ActionResult<string> UpdatePostLike([FromHeader] string postId, [FromQuery] string userId)
        {
            try
            {
                return postModel.UpdatePostLike(postId,userId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpPost]
        [Route("comment")]
        public ActionResult<string> AddComment([FromHeader] string postId,[FromBody] Comment comment,[FromQuery] string userId)
        {
            try
            {
                return postModel.CommentPost(postId,comment,userId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpDelete]
        [Route("comment")]
        public ActionResult<string> RemoveComment([FromHeader] string postId,[FromQuery] string commentId,[FromQuery] string userId)
        {
            try
            {
                return postModel.RemoveComment(postId,commentId,userId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}