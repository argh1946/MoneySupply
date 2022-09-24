using Core.Contracts.AtmCrs;
using Core.Contracts.RequestStatus;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class RequestStatusRepository : RepositoryBase<RequestStatus>, IRequestStatusRepository
    {
        public RequestStatusRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
