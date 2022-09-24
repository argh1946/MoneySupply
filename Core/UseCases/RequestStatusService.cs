using Core.Contracts;
using Core.Contracts.RequestStatus;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.UseCases
{
    public class RequestStatusService : IRequestStatusService
    {
        private readonly IUnitOfWork _uow;
        public RequestStatusService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        public Task AddAsync(RequestStatus requestStatus)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RequestStatus>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<RequestStatus> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(RequestStatus requestStatus)
        {
            throw new NotImplementedException();
        }
    }
}
