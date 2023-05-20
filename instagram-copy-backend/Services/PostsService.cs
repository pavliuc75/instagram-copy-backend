using instagram_copy_backend.Data;
using instagram_copy_backend.Models;

namespace instagram_copy_backend.Services;

public class PostsService
{
    private readonly ApplicationDbContext _applicationDbContext;

    public PostsService(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    public IEnumerable<Post> GetPosts()
    {
        return _applicationDbContext.Posts;
    }
    
    public Post GetPost(long id)
    {
        return _applicationDbContext.Posts.Find(id);
    }
    
    
    public Post CreatePost(Post post)
    {
        var createdPost = _applicationDbContext.Posts.Add(post);
        _applicationDbContext.SaveChanges();
        return createdPost.Entity;
    }
    
    public void DeletePost(long id)
    {
        var post = GetPost(id);
        _applicationDbContext.Remove(post);
        _applicationDbContext.SaveChanges();
    }
}