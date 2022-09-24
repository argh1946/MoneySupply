using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Request
{
    public class RequestEFardaService : IRequestEFardaService
    {
        private readonly IUnitOfWork _uow;
        public RequestEFardaService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }
    }
}
