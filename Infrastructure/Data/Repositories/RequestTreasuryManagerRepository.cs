using Core.Contracts.Request;
using Core.Entities;

namespace Infrastructure.Data.Repositories
{
    public class RequestTreasuryManagerRepository : RepositoryBase<Request>, IRequestTreasuryManagerRepository
    {
        public RequestTreasuryManagerRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
