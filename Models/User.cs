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
        public DateTime CreatedAt { get; set; } // Date when the user was created
        [AllowNull]
        public DateTime LastUpdatedAt { get; set; } // Date when the user was last updated

        public ICollection<Post> Posts { get; set; } = new List<Post>(); // Collection of posts created by the user


    }
}
