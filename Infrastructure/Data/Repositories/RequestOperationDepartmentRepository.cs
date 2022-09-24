using Core.Contracts.Request;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class RequestOperationDepartmentRepository : RepositoryBase<Request>, IRequestOperationDepartmentRepository
    {
        public RequestOperationDepartmentRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}

