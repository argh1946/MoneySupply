using Core.Contracts;
using Core.Contracts.Request;

namespace Core.UseCases
{
    public class RequestEFardaService : IRequestEFardaService
    {
        private readonly IUnitOfWork _uow;
        public RequestEFardaService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        #region پول گذاری
        public async Task<IEnumerable<Entities.Request>> GetRequestEFardaAsync()
        {
            var data = await _uow.RequestEFardaRepository.GetAllAsync(d => d.StatusId == 1);
            return data;
        }

        public async Task ConfirmEFardaAsync(int requestId, string des)
        {
            var item = await _uow.RequestEFardaRepository.GetByIdAsync(requestId);
            item.StatusId = 2;
            item.ModifiedDate = DateTime.Now;
            await _uow.RequestStatusRepository.AddAsync(new Entities.RequestStatus() { RequestId = requestId, StatusId = 2, Description = des, DateTime = DateTime.Now });
            _uow.RequestEFardaRepository.Update(item);
            await _uow.CommitAsync();
        }

        public async Task RejectEFardaAsync(int requestId, string des)
        {
            var item = await _uow.RequestEFardaRepository.GetByIdAsync(requestId);
            item.StatusId = 12;
            item.ModifiedDate = DateTime.Now;
            await _uow.RequestStatusRepository.AddAsync(new Entities.RequestStatus() { RequestId = requestId, StatusId = 12, Description = des, DateTime = DateTime.Now });
            _uow.RequestEFardaRepository.Update(item);
            await _uow.CommitAsync();
        }
        #endregion
    }
}