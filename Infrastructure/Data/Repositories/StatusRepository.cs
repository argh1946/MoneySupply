using Core.Contracts.Status;
using Core.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class StatusRepository : RepositoryBase<Status>, IStatusRepository
    {
        protected ApplicationDbContext _db { get; private set; }

        public StatusRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Status> GetSPByIdAsync(int id)
        {
            List<Status> list;
            string sql = "EXEC GetStatus @Id";
            List<SqlParameter> parms = new List<SqlParameter>
            {
                new SqlParameter { ParameterName = "@Id", Value = id }
            };
            var data = await _db.Status.FromSqlRaw<Status>(sql,parms.ToArray()).ToListAsync();
            return data.FirstOrDefault();
        }
    }
}
