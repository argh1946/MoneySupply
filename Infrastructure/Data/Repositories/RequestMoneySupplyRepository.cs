using Core.Contracts.Request;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class RequestMoneySupplyRepository : RepositoryBase<Request>, IRequestMoneySupplyRepository
    {
        public RequestMoneySupplyRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}

