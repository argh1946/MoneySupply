using Core.Contracts;
using Core.Contracts.Request;
using Core.Entities;

namespace Core.UseCases
{
    public class RequestMoneySupplyService : IRequestMoneySupplyService
    {
        private readonly IUnitOfWork _uow;
        public RequestMoneySupplyService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        public async Task AddAsync(Entities.Request request)
        {
            await _uow.RequestMoneySupplyRepository.AddAsync(request);
            await _uow.CommitAsync();
        }

        public async Task Update(Entities.Request request)
        {
            _uow.RequestMoneySupplyRepository.Update(request);
            await _uow.CommitAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _uow.RequestMoneySupplyRepository.DeleteAsync(id);
            await _uow.CommitAsync();
        }

        public Task<Entities.Request> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        #region تسویه
        public async Task<IEnumerable<Entities.Request>> GetSettlementMoneySupplyAsync()
        {
            var data = await _uow.RequestMoneySupplyRepository.GetAllAsync(d => d.StatusId == 6);
            return data;
        }

        public async Task ConfirmSettlementMoneySupplyAsync(int requestId, string des)
        {
            var item = await _uow.RequestMoneySupplyRepository.GetByIdAsync(requestId);
            item.StatusId = 7;
            item.ModifiedDate = DateTime.Now;
            await _uow.RequestStatusRepository.AddAsync(new Entities.RequestStatus() { RequestId = requestId, StatusId = 7, Description = des, DateTime = DateTime.Now });
            _uow.RequestMoneySupplyRepository.Update(item);
            await _uow.CommitAsync();
        }

        public async Task RejectSettlementMoneySupplyAsync(int requestId, string des)
        {
            var item = await _uow.RequestMoneySupplyRepository.GetByIdAsync(requestId);
            item.StatusId = 17;
            item.ModifiedDate = DateTime.Now;
            await _uow.RequestStatusRepository.AddAsync(new Entities.RequestStatus() { RequestId = requestId, StatusId = 17, Description = des, DateTime = DateTime.Now });
            _uow.RequestMoneySupplyRepository.Update(item);
            await _uow.CommitAsync();
        }

        public async Task AddWithFileAsync(Request request)
        {
            await _uow.RequestMoneySupplyRepository.AddWithFile(request);
            await _uow.CommitAsync();
        }
        #endregion
    }
}