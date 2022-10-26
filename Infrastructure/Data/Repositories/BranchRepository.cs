using Core.Contracts.Branch;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories
{
    public class BranchRepository : RepositoryBaseDeposit<Branch>, IBranchRepository
    {
        public BranchRepository(DepositDbContext db) : base(db)
        {

        }

        public async Task<IEnumerable<Branch>> GetAll()
        {

            var query = await _db.Branch.ToListAsync();

            return query;
        }
    }
}
