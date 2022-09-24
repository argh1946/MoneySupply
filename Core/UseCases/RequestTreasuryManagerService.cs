using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Request
{
    public class RequestTreasuryManagerService : IRequestTreasuryManagerService
    {
        private readonly IUnitOfWork _uow;
        public RequestTreasuryManagerService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }
    }
}
