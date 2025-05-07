using Microsoft.OpenApi.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace XClone.Models
{
    public enum ReferenceTypeEnum
    {
        None,
        repost,
        quote
    }

    public class Post
    {
        [Key]
        public Guid PostId { get; set; } // Unique identifier for the post
        [AllowNull]
        
        //add validation here to only make the content empty in case of repost or there are media otherwise it's invalid
        public string PostContent { get; set; } = string.Empty; // Content of the post

        [AllowNull]
        public Guid PostMediaId { get; set; } = default!; // Identifier for the media associated with the post

        [ForeignKey("PostMediaId")]
        public PostMedia postMedia { get; set; } = default!; // Media associated with the post

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;// Date when the post was created
        [AllowNull]
        public DateTime LastUpdatedAt { get; set; } = default!; // Date when the post was last updated
        public Guid UserId { get; set; } // Identifier for the user who created the post
        [ForeignKey("UserId")]
        [Required]
        public User user { get; set; } = default!; // User who created the post
        [Required]
        public ReferenceTypeEnum ReferenceType { get; set; } = ReferenceTypeEnum.None;
    }
}
