using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Request
{
    public class RequestMoneySupplyService : IRequestMoneySupplyService
    {
        private readonly IUnitOfWork _uow;
        public RequestMoneySupplyService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }
    }
}
