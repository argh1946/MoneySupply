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

        public async Task ConfirmTreasuryManagerAsync(int requestId, string des)
        {
            var item = await _uow.RequestTreasuryManagerRepository.GetByIdAsync(requestId);
            item.StatusId = 3;
            item.ModifiedDate = DateTime.Now;
            await _uow.RequestStatusRepository.AddAsync(new Entities.RequestStatus() { RequestId = requestId, StatusId = 3, Description = des, DateTime = DateTime.Now });
            _uow.RequestTreasuryManagerRepository.Update(item);
            await _uow.CommitAsync();
        }

        public async Task<IEnumerable<Entities.Request>> GetRequestTreasuryManagerAsync()
        {
            var data = await _uow.RequestTreasuryManagerRepository.GetAllAsync(d => d.StatusId == 3);
            return data;
        }

        public async Task RejectTreasuryManagerAsync(int requestId, string des)
        {
            var item = await _uow.RequestTreasuryManagerRepository.GetByIdAsync(requestId);
            item.StatusId = 13;
            item.ModifiedDate = DateTime.Now;
            await _uow.RequestStatusRepository.AddAsync(new Entities.RequestStatus() { RequestId = requestId, StatusId = 13, Description = des, DateTime = DateTime.Now });
            _uow.RequestTreasuryManagerRepository.Update(item);
            await _uow.CommitAsync();
        }
    }
}
