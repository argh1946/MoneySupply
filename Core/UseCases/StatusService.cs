using Core.Contracts;
using Core.Contracts.Status;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.UseCases
{
    public class StatusService : IStatusService
    {
        private readonly IUnitOfWork _uow;
        public StatusService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }
        public async Task<IEnumerable<Status>> GetAllAsync()
        {
            var data = await _uow.StatusRepository.GetAllAsync(null, x => x.OrderByDescending(x => x.Id));
            return data;
        }

        public async Task<Status> GetByIdAsync(int id)
        {
            var data = await _uow.StatusRepository.GetByIdAsync(id);
            return data;
        }

        public async Task AddAsync(Status status)
        {
            await _uow.StatusRepository.AddAsync(status);
            await _uow.CommitAsync();
        }

        public async Task Update(Status status)
        {
            _uow.StatusRepository.Update(status);
            await _uow.CommitAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _uow.StatusRepository.DeleteAsync(id);
            await _uow.CommitAsync();
        }

        public async Task<Status> GetSPByIdAsync(int id)
        {
            var data = await _uow.StatusRepository.GetSPByIdAsync(id);
            return data;
        }
    }
}
