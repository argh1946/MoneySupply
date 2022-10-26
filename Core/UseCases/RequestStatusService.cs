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

        public async Task<IEnumerable<RequestStatus>> GetAllAsync()
        {
            var data = await _uow.RequestStatusRepository.GetAllAsync(null, x => x.OrderByDescending(x => x.Id));
            return data;
        }

        public async Task<RequestStatus> GetByIdAsync(int id)
        {
            var data = await _uow.RequestStatusRepository.GetByIdAsync(id);
            return data;
        }

        public async Task AddAsync(RequestStatus requestStatus)
        {
            await _uow.RequestStatusRepository.AddAsync(requestStatus);
            await _uow.CommitAsync();
        }

        public async Task Update(RequestStatus requestStatus)
        {
            _uow.RequestStatusRepository.Update(requestStatus);
            await _uow.CommitAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _uow.RequestStatusRepository.DeleteAsync(id);
            await _uow.CommitAsync();
        }
    }
}