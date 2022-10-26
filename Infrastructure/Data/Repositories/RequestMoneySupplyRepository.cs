using Core.Contracts.Request;
using Core.Entities;

namespace Infrastructure.Data.Repositories
{
    public class RequestMoneySupplyRepository : RepositoryBase<Request>, IRequestMoneySupplyRepository
    {
        public RequestMoneySupplyRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}

