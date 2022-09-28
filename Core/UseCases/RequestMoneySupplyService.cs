using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Request
{
    public class RequestMoneySupplyService : IRequestMoneySupplyService
    {
        private readonly IUnitOfWork _uow;
        public RequestMoneySupplyService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        #region پول گذاری
        public async Task<IEnumerable<Entities.Request>> GetRequestMoneySupplyAsync()
        {
            var data = await _uow.RequestMoneySupplyRepository.GetAllAsync(d => d.StatusId == 1);
            return data;
        }

        public async Task AddAsync(Entities.Request request)
        {
            await _uow.RequestMoneySupplyRepository.AddAsync(request);
            await _uow.CommitAsync();
        }

        #endregion

        #region تسویه
        public async Task<IEnumerable<Entities.Request>> GetSettlementMoneySupplyAsync()
        {
            var data = await _uow.RequestMoneySupplyRepository.GetAllAsync(d => d.StatusId == 7);
            return data;
        }

        #endregion

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Entities.Request> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task Update(Entities.Request status)
        {
            throw new NotImplementedException();
        }



    }
}
