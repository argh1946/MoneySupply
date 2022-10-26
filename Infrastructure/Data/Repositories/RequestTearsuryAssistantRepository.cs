using Core.Contracts.Request;
using Core.Entities;

namespace Infrastructure.Data.Repositories
{
    public class RequestTearsuryAssistantRepository : RepositoryBase<Request>, IRequestTearsuryAssistantRepository
    {
        public RequestTearsuryAssistantRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}


