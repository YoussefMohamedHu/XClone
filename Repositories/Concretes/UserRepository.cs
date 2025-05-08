using Microsoft.EntityFrameworkCore;
using XClone.Data;
using XClone.Models;
using XClone.Repositories.Interfaces;

namespace XClone.Repositories.Concretes
{
    public class UserRepository : Repository<User> , IUserRepository
    {
        public UserRepository(MyDbContext context) : base(context)
        {

        }
    }
}
