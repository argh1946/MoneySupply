using Core.Contracts.Request;
using Core.Entities;

namespace Infrastructure.Data.Repositories
{
    public class RequestTreasuryAccountantRepository : RepositoryBase<Request>, IRequestTreasuryAccountantRepository
    {
        public RequestTreasuryAccountantRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}

