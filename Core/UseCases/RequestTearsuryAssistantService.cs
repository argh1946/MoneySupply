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


        #region تسویه

        public async Task ConfirmSettlementTearsuryAssistantAsync(int requestId, string des)
        {
            var item = await _uow.RequestEFardaRepository.GetByIdAsync(requestId);
            item.StatusId = 6;
            item.ModifiedDate = DateTime.Now;
            await _uow.RequestStatusRepository.AddAsync(new Entities.RequestStatus() { RequestId = requestId, StatusId = 6, Description = des, DateTime = DateTime.Now });
            _uow.RequestEFardaRepository.Update(item);
            await _uow.CommitAsync();
        }

        public async Task<IEnumerable<Entities.Request>> GetSettlementTearsuryAssistantAsync()
        {
            var data = await _uow.RequestMoneySupplyRepository.GetAllAsync(d => d.StatusId == 6);
            return data;
        }

        public async Task RejectSettlementTearsuryAssistantAsync(int requestId, string des)
        {
            var item = await _uow.RequestEFardaRepository.GetByIdAsync(requestId);
            item.StatusId = 16;
            item.ModifiedDate = DateTime.Now;
            await _uow.RequestStatusRepository.AddAsync(new Entities.RequestStatus() { RequestId = requestId, StatusId = 16, Description = des, DateTime = DateTime.Now });
            _uow.RequestEFardaRepository.Update(item);
            await _uow.CommitAsync();
        }

        #endregion
    }
}
