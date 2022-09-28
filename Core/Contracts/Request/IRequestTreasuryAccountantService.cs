using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Request
{
    public interface IRequestTreasuryAccountantService
    {
        Task<IEnumerable<Entities.Request>> GetRequestTreasuryAccountantAsync();
        Task ConfirmTreasuryAccountantAsync(int requestId, string des);
        Task RejectTreasuryAccountantAsync(int requestId, string des);
    }
}
