namespace XClone.Models
{
    enum MediaType
    {
        None ,Image , Video
    }
    public class PostMedia
    {
        public Guid PostMediaId { get; set; } // Unique identifier for the media
        public List<string> MediaUrl { get; set; } = default!; // List of URLs for the media
        public List<string> MediaType { get; set; } = default!; // List of media types (e.g., image, video)

    }
}