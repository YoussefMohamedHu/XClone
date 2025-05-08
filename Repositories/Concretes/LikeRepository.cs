using Microsoft.EntityFrameworkCore;
using XClone.Data;
using XClone.Models;

namespace XClone.Repositories.Concretes
{
    public class LikeRepository : Repository<Like>, ILikeRepository
    {
        public LikeRepository(MyDbContext context) : base(context)
        {
        }
    }
}
