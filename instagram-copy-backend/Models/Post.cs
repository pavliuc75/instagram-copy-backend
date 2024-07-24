namespace instagram_copy_backend.Models;

public class Post
{
    public long Id { get; set; }
    public string? Title { get; set; }
    public ICollection<Comment> Comments { get; set; } = new List<Comment>(); // Navigation property for related comments
}