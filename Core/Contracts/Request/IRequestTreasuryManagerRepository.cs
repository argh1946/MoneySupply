using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Request
{
    public interface IRequestTreasuryManagerRepository : IAsyncGenericRepository<Entities.Request>
    {
    }
}
