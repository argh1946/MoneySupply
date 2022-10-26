using Core.Contracts.RequestStatus;
using Core.Entities;

namespace Infrastructure.Data.Repositories
{
    public class RequestStatusRepository : RepositoryBase<RequestStatus>, IRequestStatusRepository
    {
        public RequestStatusRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
