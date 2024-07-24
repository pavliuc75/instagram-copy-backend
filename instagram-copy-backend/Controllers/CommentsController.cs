using instagram_copy_backend.Models;
using instagram_copy_backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace instagram_copy_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class CommentsController : ControllerBase
{
    private CommentsService _service;

    public CommentsController(CommentsService commentsService)
    {
        _service = commentsService;
    }

    [HttpGet]
    public IEnumerable<Comment> GetComments()
    {
        return _service.GetAllComments();
    }

    [HttpPost("{postId}")]
    public void PostComment(int postId, [FromBody] Comment comment)
    {
        _service.AddComment(comment, postId);
    }
}