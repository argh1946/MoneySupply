using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Request
{
    public class RequestOperationDepartmentService : IRequestOperationDepartmentService
    {
        private readonly IUnitOfWork _uow;
        public RequestOperationDepartmentService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
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

        public async Task<IEnumerable<Entities.Request>> GetRequestOperationDepartmentAsync()
        {
            var data = await _uow.RequestOperationDepartmentRepository.GetAllAsync(d => d.StatusId == 5);
            return data;
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
    }
}
