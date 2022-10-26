using Core.Contracts.Status;
using Core.Entities;

namespace Infrastructure.Data.Repositories
{
    public class StatusRepository : RepositoryBase<Status>, IStatusRepository
    {
        public StatusRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
