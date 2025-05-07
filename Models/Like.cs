using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XClone.Models
{
    public class Like
    {
        //composite key
        public Guid PostId { get; set; }
        [Required]
        [ForeignKey("PostId")]
        public Post Post { get; set; } = default!;

        //composite key
        public Guid UserSendLikeId { get; set; } = default!;
        [Required]

        [ForeignKey("UserSendLikeId")]
        public User UserSendLike { get; set; } = default!;
        
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


    }
}
