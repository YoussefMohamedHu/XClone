using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XClone.Models
{
    public class Bookmark
    {
        //composite key
        public Guid PostId { get; set; } // Unique identifier for the bookmark

        [ForeignKey("PostId")]
        [Required]
        public Post Post { get; set; } = default!; // Navigation property to the associated post

        //composite key
        public Guid UserId { get; set; } // Unique identifier for the user
        [ForeignKey("UserId")]
        [Required]
        public User User { get; set; } = default!; // Navigation property to the associated user
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Date when the bookmark was created
    }
}
