using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XClone.Models
{
    public enum MediaTypeEnum // Changed from internal to public to fix CS0053  
    {
        None, Image, Video
    }
    public class PostMedia
    {
         // Unique identifier for the media

        public Guid PostMediaId { get; set; } // Unique identifier for the media  
        [Required]
        [ForeignKey("PostMediaId")] 
        public Post Post { get; set; } = default!; // Navigation property to the associated post
        public List<string> MediaUrl { get; set; } = new(); 
        public List<MediaTypeEnum> MediaType { get; set; } = new();
        public DateTime CreatedAt { get; set; } // Date when the media was created
    }
}