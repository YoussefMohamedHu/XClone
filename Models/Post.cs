namespace XClone.Models
{
    public class Post
    {
        public Guid PostId { get; set; } // Unique identifier for the post
        public string PostContent { get; set; } = default!; // Content of the post
        public PostMedia postMedia { get; set; } = default!; // Media associated with the post
        public DateTime CreatedAt { get; set; } // Date when the post was created
        public DateTime LastUpdatedAt { get; set; } // Date when the post was last updated
        public Guid UserId { get; set; } // Identifier for the user who created the post
    }
}
