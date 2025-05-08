using XClone.Data;
using XClone.Models;

namespace XClone.Repositories.Concretes
{
    public class BookmarkRepository : Repository<Bookmark> , IBookmarkRepository
    {
        public BookmarkRepository(MyDbContext context) : base(context)
        {
        }
    }
    {
    }
}
