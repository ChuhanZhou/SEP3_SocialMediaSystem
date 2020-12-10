using System;
using System.Text.Json;
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
        public async Task<ActionResult<string>> AddPost([FromBody] Post newPost,[FromQuery] string userId)
        {
            Console.WriteLine(userId);
            try
            {
                Console.WriteLine("Post receive from [" + userId + "]:" + JsonSerializer.Serialize(newPost));
                var result = await postModel.AddPost(newPost, userId);
                Console.WriteLine("Post send to [" + userId + "]:" + result);
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<string>> GetPost([FromQuery] string userId)
        {
            try
            {
                if (userId!=null)
                {
                    return Ok(JsonSerializer.Serialize(await postModel.GetPostToShowByUserId(userId), new JsonSerializerOptions {WriteIndented = true}));
                }
                return Ok(JsonSerializer.Serialize(postModel.GetAllPosts(), new JsonSerializerOptions {WriteIndented = true}));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult<string>> UpdatePost([FromBody] Post newPost, [FromQuery] string userId)
        {
            try
            {
                return await postModel.UpdatePostBySender(newPost,userId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpDelete]
        public ActionResult<string> RemovePost([FromQuery] string postId, [FromQuery] string userId)
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
        public async Task<ActionResult<string>> UpdatePostLike([FromQuery] string postId, [FromQuery] string userId)
        {
            try
            {
                return await postModel.UpdatePostLike(postId,userId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpPost]
        [Route("comment")]
        public async Task<ActionResult<string>> AddComment([FromQuery] string postId,[FromBody] Comment comment,[FromQuery] string userId)
        {
            try
            {
                return await postModel.CommentPost(postId,comment,userId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpDelete]
        [Route("comment")]
        public async Task<ActionResult<string>> RemoveComment([FromQuery] string postId,[FromQuery] string commentId,[FromQuery] string userId)
        {
            try
            {
                return await postModel.RemoveComment(postId,commentId,userId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}