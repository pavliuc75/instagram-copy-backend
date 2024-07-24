using instagram_copy_backend.Data;
using instagram_copy_backend.Models;

namespace instagram_copy_backend.Services;

public class CommentsService
{
    private readonly ApplicationDbContext ctx;

    public CommentsService(ApplicationDbContext applicationDbContext)
    {
        ctx = applicationDbContext;
    }

    public List<Comment> GetAllComments()
    {
        return ctx.Comments.ToList();
    }

    public Comment AddComment(Comment newComment, int postId)
    {
        newComment.PostId = postId;
        ctx.Add(newComment);
        ctx.SaveChanges();
        return newComment;
    }
}