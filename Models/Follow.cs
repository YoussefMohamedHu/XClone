using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XClone.Models
{
    public class Follow
    {
        // composite key
        public Guid FollowerId { get; set; }
        // composite key
        public Guid FollowingId { get; set; }
        [Required]
        [ForeignKey("FollowerId")]
        public User Follower { get; set; } = default!;
        [Required]
        [ForeignKey("FollowingId")]
        public User Following = default!;
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Date when the follow was created
    }
}
