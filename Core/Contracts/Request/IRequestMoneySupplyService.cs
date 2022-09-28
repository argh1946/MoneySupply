using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Request
{
    public interface IRequestMoneySupplyService
    {
        Task<IEnumerable<Entities.Request>> GetRequestMoneySupplyAsync();
        Task<IEnumerable<Entities.Request>> GetSettlementMoneySupplyAsync();
        Task<Entities.Request> GetByIdAsync(int id);
        Task AddAsync(Entities.Request request);
        Task Update(Entities.Request request);
        Task DeleteAsync(int id);

    }
}
