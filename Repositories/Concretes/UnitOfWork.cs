using Microsoft.EntityFrameworkCore;
using XClone.Data;
using XClone.Repositories.Interfaces;

namespace XClone.Repositories.Concretes
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyDbContext _context;
        IBookmarkRepository _bookmarkRepository;
        IUserRepository _userRepository;
        IPostRepository _postRepository;
        IPostMediaRepository _postMediaRepository;
        IFollowRepository _followRepository;
        ILikeRepository _likeRepository;


        public UnitOfWork(MyDbContext context)
        {
            _context = context;
            _bookmarkRepository = new BookmarkRepository(context);
            _userRepository = new UserRepository(context);
            _postRepository = new PostRepository(context);
            _followRepository = new FollowRepository(context);
            _likeRepository = new LikeRepository(context);
            _postMediaRepository = new PostMediaRepository(context);


        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
            
        }
    }
}
