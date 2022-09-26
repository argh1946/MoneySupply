using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Request
{
    public class RequestEFardaService : IRequestEFardaService
    {
        private readonly IUnitOfWork _uow;
        public RequestEFardaService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        public async Task<IEnumerable<Entities.Request>> GetRequestEFardaAsync()
        {
            var data = await _uow.RequestEFardaRepository.GetAllAsync(d => d.StatusId == 2);
            return data;
        }

        public async Task ConfirmEFardaAsync(int requestId,string des)
        {
            var item = await _uow.RequestEFardaRepository.GetByIdAsync(requestId);
            item.StatusId = 2;
            item.ModifiedDate = DateTime.Now;
            await _uow.RequestStatusRepository.AddAsync(new Entities.RequestStatus() { RequestId = requestId,StatusId = 2 , Description = des,DateTime= DateTime.Now });
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
    }
}
