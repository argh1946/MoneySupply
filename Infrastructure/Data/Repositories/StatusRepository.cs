using Core.Contracts.Status;
using Core.Entities;
using Core.Helper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories
{
    public class StatusRepository : RepositoryBase<Status>, IStatusRepository
    {
        public StatusRepository(ApplicationDbContext db) : base(db)
        {
        }

        public async Task<PaginatedList<Status>> GetAllPagedAsync()
        {
            return await _db.Status.PaginatedListAsync();
        }

        public async Task<Status> GetSPByIdAsync(int id)
        {
            List<Status> list;
            string sql = "EXEC GetStatus @Id";
            List<SqlParameter> parms = new List<SqlParameter>
            {
                new SqlParameter { ParameterName = "@Id", Value = id }
            };
            var data = await _db.Status.FromSqlRaw<Status>(sql, parms.ToArray()).ToListAsync();
            return data.FirstOrDefault();
        }
    }
}
