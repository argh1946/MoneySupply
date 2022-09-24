using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Request
{
    public class RequestTreasuryAccountantService : IRequestTreasuryAccountantService
    {
        private readonly IUnitOfWork _uow;
        public RequestTreasuryAccountantService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }
    }
}
