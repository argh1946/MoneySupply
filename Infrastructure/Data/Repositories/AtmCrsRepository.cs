using Core.Entities;
using Core.Contracts.AtmCrs;

namespace Infrastructure.Data.Repositories
{
    public class AtmCrsRepository : RepositoryBase<AtmCrs>, IAtmCrsRepository
    {
        public AtmCrsRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}