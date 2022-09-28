using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Request
{
    public interface IRequestTreasuryManagerService
    {
        Task<IEnumerable<Entities.Request>> GetRequestTreasuryManagerAsync();
        Task ConfirmTreasuryManagerAsync(int requestId, string des);
        Task RejectTreasuryManagerAsync(int requestId, string des);
    }
}
