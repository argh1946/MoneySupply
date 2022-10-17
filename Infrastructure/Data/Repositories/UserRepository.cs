using Core.Contracts.AtmCrs;
using Core.Contracts.User;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class UserRepository : RepositoryBaseSon<User>, IUserRepository
    {
        public UserRepository(SonDbContext db) : base(db)
        {
        }

    }
}
