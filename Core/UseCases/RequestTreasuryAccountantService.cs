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

        public async Task ConfirmTreasuryAccountantAsync(int requestId, string des)
        {
            var item = await _uow.RequestTreasuryAccountantRepository.GetByIdAsync(requestId);
            item.StatusId = 4;
            item.ModifiedDate = DateTime.Now;
            await _uow.RequestStatusRepository.AddAsync(new Entities.RequestStatus() { RequestId = requestId, StatusId = 4, Description = des, DateTime = DateTime.Now });
            _uow.RequestTreasuryAccountantRepository.Update(item);
            await _uow.CommitAsync();
        }

        public async Task<IEnumerable<Entities.Request>> GetRequestTreasuryAccountantAsync()
        {
            var data = await _uow.RequestTreasuryAccountantRepository.GetAllAsync(d => d.StatusId == 4);
            return data;
        }

        public async Task RejectTreasuryAccountantAsync(int requestId, string des)
        {
            var item = await _uow.RequestTreasuryAccountantRepository.GetByIdAsync(requestId);
            item.StatusId = 14;
            item.ModifiedDate = DateTime.Now;
            await _uow.RequestStatusRepository.AddAsync(new Entities.RequestStatus() { RequestId = requestId, StatusId = 14, Description = des, DateTime = DateTime.Now });
            _uow.RequestTreasuryAccountantRepository.Update(item);
            await _uow.CommitAsync();
        }
    }
}
