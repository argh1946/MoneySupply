using Core.Contracts;
using Core.Contracts.Request;

namespace Core.UseCases
{
    public class RequestTreasuryAccountantService : IRequestTreasuryAccountantService
    {
        private readonly IUnitOfWork _uow;
        public RequestTreasuryAccountantService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        #region پول گذاری
        public async Task<IEnumerable<Entities.Request>> GetRequestTreasuryAccountantAsync()
        {
            var data = await _uow.RequestTreasuryAccountantRepository.GetAllAsync(d => d.StatusId == 3);
            return data;
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

        public async Task RejectTreasuryAccountantAsync(int requestId, string des)
        {
            var item = await _uow.RequestTreasuryAccountantRepository.GetByIdAsync(requestId);
            item.StatusId = 14;
            item.ModifiedDate = DateTime.Now;
            await _uow.RequestStatusRepository.AddAsync(new Entities.RequestStatus() { RequestId = requestId, StatusId = 14, Description = des, DateTime = DateTime.Now });
            _uow.RequestTreasuryAccountantRepository.Update(item);
            await _uow.CommitAsync();
        }
        #endregion

        #region تسویه
        public async Task<IEnumerable<Entities.Request>> GetSettlementTreasuryAccountantAsync()
        {
            var data = await _uow.RequestTreasuryAccountantRepository.GetAllAsync(d => d.StatusId == 8);
            return data;
        }

        public async Task ConfirmSettlementTreasuryAccountantAsync(int requestId, string des)
        {
            var item = await _uow.RequestTreasuryAccountantRepository.GetByIdAsync(requestId);
            item.StatusId = 9;
            item.ModifiedDate = DateTime.Now;
            await _uow.RequestStatusRepository.AddAsync(new Entities.RequestStatus() { RequestId = requestId, StatusId = 9, Description = des, DateTime = DateTime.Now });
            _uow.RequestTreasuryAccountantRepository.Update(item);
            await _uow.CommitAsync();
        }

        public async Task RejectSettlementTreasuryAccountantAsync(int requestId, string des)
        {
            var item = await _uow.RequestTreasuryAccountantRepository.GetByIdAsync(requestId);
            item.StatusId = 19;
            item.ModifiedDate = DateTime.Now;
            await _uow.RequestStatusRepository.AddAsync(new Entities.RequestStatus() { RequestId = requestId, StatusId = 19, Description = des, DateTime = DateTime.Now });
            _uow.RequestTreasuryAccountantRepository.Update(item);
            await _uow.CommitAsync();
        }
        #endregion
    }
}