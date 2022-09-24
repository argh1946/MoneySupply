using Core.Entities;
using Microsoft.Extensions.Configuration;
using Core.Contracts.MoneyType;

namespace Infrastructure.Data
{
    public class MoneyTypeRepository : RepositoryBase<MoneyType>, IMoneyTypeRepository
    {
        public MoneyTypeRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}