using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Request
{
    public class RequestOperationDepartmentService : IRequestOperationDepartmentService
    {
        private readonly IUnitOfWork _uow;
        public RequestOperationDepartmentService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }
    }
}
