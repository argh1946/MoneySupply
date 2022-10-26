using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Branch
{
    public interface IBranchRepository :IAsyncGenericDepositRepository<Entities.Branch>
    {
        Task<IEnumerable<Entities.Branch>> GetAll();
    }
}
