using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace XClone.Models
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; } // Unique identifier for the user
        [Required]
        public string UserName { get; set; } = default!; // Username of the user
        [Required]
        public string UserEmail { get; set; } = default!;
        [Required]
        public string UserPasswordHashed { get; set; } = default!;
        [Required]
        public string Name { get; set; } = default!;// Name of the user
        [AllowNull]
        public string PhoneNumber { get; set; } = string.Empty;// Phone number of the user
        [AllowNull]
        public string Bio { get; set; } = string.Empty; // Bio of the user
        [AllowNull]
        public string ProfileImageUrl { get; set; } = string.Empty; // Profile picture of the user
        [AllowNull]
        public string CoverImageUrl { get; set; } = string.Empty; // Cover image of the user

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Date when the user was created
        [Required]
        public DateTime LastUpdatedAt { get; set; } = DateTime.UtcNow; // Date when the user was last updated

        public ICollection<Post> Posts { get; set; } = new List<Post>(); // Collection of posts created by the user
        public ICollection<Like> Likes { get; set; } = new List<Like>(); // Collection of likes given by the user
        public ICollection<Bookmark> Bookmarks { get; set; } = new List<Bookmark>(); // Collection of bookmarks created by the user
        public ICollection<Follow> Followers { get; set; } = new List<Follow>(); // Collection of followers of the user

        public ICollection<Follow> Followings { get; set; } = new List<Follow>(); // Collection of followings of the user

    }
}
