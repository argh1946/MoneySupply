using Core.Entities;
using Core.Contracts.MoneyType;

namespace Infrastructure.Data.Repositories
{
    public class MoneyTypeRepository : RepositoryBase<MoneyType>, IMoneyTypeRepository
    {
        public MoneyTypeRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}