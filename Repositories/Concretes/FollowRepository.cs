using Microsoft.EntityFrameworkCore;
using XClone.Data;
using XClone.Models;

namespace XClone.Repositories.Concretes
{
    public class FollowRepository : Repository<Follow>, IFollowRepository
    {
        public FollowRepository(MyDbContext context) : base(context)
        {
        }
    }
}
