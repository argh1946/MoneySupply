using Core.Contracts;
using Core.Contracts.AtmCrs;
using Core.Entities;

namespace Core.UseCases
{
    public class AtmCrsService : IAtmCrsService
    {
        private readonly IUnitOfWork _uow;
        public AtmCrsService(IUnitOfWork uow)
        {
            _uow = uow;
        }


        public async Task<IEnumerable<AtmCrs>> GetAllAsync()
        {
            var data = await _uow.AtmCrsRepository.GetAllAsync(null, x => x.OrderByDescending(x => x.Id));
            return data;
           
        }
    }
}