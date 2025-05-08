using Microsoft.EntityFrameworkCore;
using XClone.Data;
using XClone.Models;

namespace XClone.Repositories.Concretes
{
    public class PostMediaRepository : Repository<PostMedia>, IPostMediaRepository
    {
        public PostMediaRepository(MyDbContext context) : base(context)
        {

        }
    }
}
