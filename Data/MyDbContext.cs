using Microsoft.EntityFrameworkCore;
using XClone.Models;

namespace XClone.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        // DbSet properties for your entities
        public DbSet<Bookmark> Bookmarks { get; set; }
        public DbSet<Follow> Follows { get; set; } 
        public DbSet<Like> Likes { get; set; } 
        public DbSet<Post> Posts { get; set; } 
        public DbSet<User> Users { get; set; } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure composite keys and relationships here if needed
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().Property(u => u.UserId).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Post>().Property(p => p.PostId).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Like>().HasKey(l => new {l.UserSendLikeId , l.PostId}).HasName("LikeId");
            modelBuilder.Entity<Bookmark>().HasKey(b => new { b.UserId, b.PostId }).HasName("BookmarkId");
            modelBuilder.Entity<Follow>().HasKey(f => new { f.FollowerId, f.FollowingId }).HasName("FollowId");
        }
    }
}
