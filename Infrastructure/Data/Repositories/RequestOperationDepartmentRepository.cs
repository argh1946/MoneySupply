using Core.Contracts.Request;
using Core.Entities;

namespace Infrastructure.Data.Repositories
{
    public class RequestOperationDepartmentRepository : RepositoryBase<Request>, IRequestOperationDepartmentRepository
    {
        public RequestOperationDepartmentRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}

