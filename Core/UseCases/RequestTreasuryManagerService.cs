using Core.Contracts;
using Core.Contracts.Request;

namespace Core.UseCases
{
    public class RequestTreasuryManagerService : IRequestTreasuryManagerService
    {
        private readonly IUnitOfWork _uow;
        public RequestTreasuryManagerService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        #region پول گذاری
        public async Task<IEnumerable<Entities.Request>> GetRequestTreasuryManagerAsync()
        {
            var data = await _uow.RequestTreasuryManagerRepository.GetAllAsync(d => d.StatusId == 2);
            return data;
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

        public async Task RejectTreasuryManagerAsync(int requestId, string des)
        {
            var item = await _uow.RequestTreasuryManagerRepository.GetByIdAsync(requestId);
            item.StatusId = 13;
            item.ModifiedDate = DateTime.Now;
            await _uow.RequestStatusRepository.AddAsync(new Entities.RequestStatus() { RequestId = requestId, StatusId = 13, Description = des, DateTime = DateTime.Now });
            _uow.RequestTreasuryManagerRepository.Update(item);
            await _uow.CommitAsync();
        }
        #endregion

        #region تسویه
        public async Task<IEnumerable<Entities.Request>> GetSettlementTreasuryManagerAsync()
        {
            var data = await _uow.RequestTreasuryManagerRepository.GetAllAsync(d => d.StatusId == 7);
            return data;
        }

        public async Task ConfirmSettlementTreasuryManagerAsyng(int requestId, string des)
        {
            var item = await _uow.RequestTreasuryManagerRepository.GetByIdAsync(requestId);
            item.StatusId = 8;
            item.ModifiedDate = DateTime.Now;
            await _uow.RequestStatusRepository.AddAsync(new Entities.RequestStatus() { RequestId = requestId, StatusId = 8, Description = des, DateTime = DateTime.Now });
            _uow.RequestTreasuryManagerRepository.Update(item);
            await _uow.CommitAsync();
        }

        public async Task RejectSettlementTreasuryManagerAsync(int requestId, string des)
        {
            var item = await _uow.RequestTreasuryManagerRepository.GetByIdAsync(requestId);
            item.StatusId = 18;
            item.ModifiedDate = DateTime.Now;
            await _uow.RequestStatusRepository.AddAsync(new Entities.RequestStatus() { RequestId = requestId, StatusId = 18, Description = des, DateTime = DateTime.Now });
            _uow.RequestTreasuryManagerRepository.Update(item);
            await _uow.CommitAsync();
        }
        #endregion
    }
}