using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Request
{
    public class RequestTearsuryAssistantService : IRequestTearsuryAssistantService
    {
        private readonly IUnitOfWork _uow;
        public RequestTearsuryAssistantService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }
    }
}
