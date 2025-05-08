using Microsoft.EntityFrameworkCore;
using XClone.Data;
using XClone.Models;

namespace XClone.Repositories.Concretes
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(MyDbContext context) : base(context)
        {

        }
    }
}
