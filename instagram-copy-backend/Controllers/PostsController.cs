using instagram_copy_backend.Models;
using instagram_copy_backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace instagram_copy_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class PostsController : ControllerBase
{
    // private readonly PostsService _postsService;

    // public PostsController(PostsService postsService)
    // {
        // _postsService = postsService;
    // }

    [HttpGet]
    public IActionResult GetPosts()
    {
        return Ok("hello loh");
        // return Ok(_postsService.GetPosts());
    }


    // [HttpGet("{id}")]
    // public IActionResult GetPost(long id)
    // {
        // return Ok(_postsService.GetPost(id));
    // }

    // [HttpPost]
    // public IActionResult CreatePost([FromBody] Post post)
    // {
        // var createdPost = _postsService.CreatePost(post);
        // return CreatedAtAction(nameof(GetPost), new { id = createdPost.Id }, createdPost);
    // }

    // [HttpDelete("{id}")]
    // public IActionResult DeletePost(long id)
    // {
        // _postsService.DeletePost(id);
        // return Ok();
    // }
}