namespace instagram_copy_backend.Models;

public class Comment
{
    public long Id { get; set; }
    public string Content { get; set; }
    public long PostId { get; set; } // Foreign key to reference Post
    public Post? Post { get; set; }  // Navigation property for Entity Framework
}