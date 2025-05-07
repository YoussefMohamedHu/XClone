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
            base.OnModelCreating(modelBuilder);

            // Configure default values for GUIDs
            modelBuilder.Entity<User>().Property(u => u.UserId).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Post>().Property(p => p.PostId).HasDefaultValueSql("NEWID()");

            // Configure composite keys
            modelBuilder.Entity<Like>().HasKey(l => new { l.UserSendLikeId, l.PostId }).HasName("LikeId");
            modelBuilder.Entity<Bookmark>().HasKey(b => new { b.UserId, b.PostId }).HasName("BookmarkId");
            modelBuilder.Entity<Follow>().HasKey(f => new { f.FollowerId, f.FollowingId }).HasName("FollowId");

            // Configure relationships to avoid multiple cascade paths
            modelBuilder.Entity<Bookmark>()
                .HasOne(b => b.Post)
                .WithMany(p => p.Bookmarks)
                .HasForeignKey(b => b.PostId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete

            modelBuilder.Entity<Bookmark>()
                .HasOne(b => b.User)
                .WithMany(u => u.Bookmarks)
                .HasForeignKey(b => b.UserId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete

            modelBuilder.Entity<Like>()
                .HasOne(l => l.Post)
                .WithMany(p => p.Likes)
                .HasForeignKey(l => l.PostId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete

            modelBuilder.Entity<Like>()
                .HasOne(l => l.UserSendLike)
                .WithMany(u => u.Likes)
                .HasForeignKey(l => l.UserSendLikeId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete

            modelBuilder.Entity<Follow>()
                .HasOne(f => f.Follower)
                .WithMany(u => u.Followers)
                .HasForeignKey(f => f.FollowerId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete

            modelBuilder.Entity<Follow>()
                .HasOne(f => f.Following)
                .WithMany(u => u.Followings)
                .HasForeignKey(f => f.FollowingId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete
            
            modelBuilder.Entity<PostMedia>()
                .HasOne(m => m.Post)
                .WithOne(p => p.PostMedia)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete


        }

    }
}
