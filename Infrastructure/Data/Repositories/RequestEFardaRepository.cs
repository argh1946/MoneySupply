using Core.Contracts.Request;
using Core.DTOs;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class RequestEFardaRepository : RepositoryBase<Request>, IRequestEFardaRepository
    {
        public RequestEFardaRepository(ApplicationDbContext db) : base(db)
        {
        }

        public async Task<IEnumerable<RequestEfardaVM>> GetRequestEFardaAsync() {

            var query = from r in _db.Request
                        join rs in _db.RequestStatus
                            on r.Id equals rs.RequestId
                        select new RequestEfardaVM {AtmCrsId = r.AtmCrsId, Description = rs.Description };

            return await query.ToListAsync();
        }
    }
}
