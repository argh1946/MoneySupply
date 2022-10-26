using Core.Contracts;
using Core.Contracts.Request;

namespace Core.UseCases
{
    public class RequestOperationDepartmentService : IRequestOperationDepartmentService
    {
        private readonly IUnitOfWork _uow;
        public RequestOperationDepartmentService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        #region پول گذاری
        public async Task<IEnumerable<Entities.Request>> GetRequestOperationDepartmentAsync()
        {
            var data = await _uow.RequestOperationDepartmentRepository.GetAllAsync(d => d.StatusId == 4);
            return data;
        }

        public async Task ConfirmOperationDepartmentAsync(int requestId, string des)
        {
            var item = await _uow.RequestOperationDepartmentRepository.GetByIdAsync(requestId);
            item.StatusId = 5;
            item.ModifiedDate = DateTime.Now;
            await _uow.RequestStatusRepository.AddAsync(new Entities.RequestStatus() { RequestId = requestId, StatusId = 5, Description = des, DateTime = DateTime.Now });
            _uow.RequestOperationDepartmentRepository.Update(item);
            await _uow.CommitAsync();
        }

        public async Task RejectOperationDepartmentAsync(int requestId, string des)
        {
            var item = await _uow.RequestOperationDepartmentRepository.GetByIdAsync(requestId);
            item.StatusId = 15;
            item.ModifiedDate = DateTime.Now;
            await _uow.RequestStatusRepository.AddAsync(new Entities.RequestStatus() { RequestId = requestId, StatusId = 15, Description = des, DateTime = DateTime.Now });
            _uow.RequestOperationDepartmentRepository.Update(item);
            await _uow.CommitAsync();
        }
        #endregion

        #region تسویه
        public async Task<IEnumerable<Entities.Request>> GetSettlementOperationDepartmentAsync()
        {
            var data = await _uow.RequestOperationDepartmentRepository.GetAllAsync(d => d.StatusId == 9);
            return data;
        }

        public async Task ConfirmSettlementOperationDepartmentAsync(int requestId, string des)
        {
            var item = await _uow.RequestOperationDepartmentRepository.GetByIdAsync(requestId);
            item.StatusId = 10;
            item.ModifiedDate = DateTime.Now;
            await _uow.RequestStatusRepository.AddAsync(new Entities.RequestStatus() { RequestId = requestId, StatusId = 10, Description = des, DateTime = DateTime.Now });
            _uow.RequestOperationDepartmentRepository.Update(item);
            await _uow.CommitAsync();
        }

        public async Task RejectSettlementOperationDepartmentAsync(int requestId, string des)
        {
            var item = await _uow.RequestOperationDepartmentRepository.GetByIdAsync(requestId);
            item.StatusId = 20;
            item.ModifiedDate = DateTime.Now;
            await _uow.RequestStatusRepository.AddAsync(new Entities.RequestStatus() { RequestId = requestId, StatusId = 20, Description = des, DateTime = DateTime.Now });
            _uow.RequestOperationDepartmentRepository.Update(item);
            await _uow.CommitAsync();
        }
        #endregion
    }
}