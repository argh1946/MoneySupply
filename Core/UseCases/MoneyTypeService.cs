using Core.Contracts;
using Core.Contracts.MoneyType;
using Core.Entities;

namespace Core.UseCases
{
    public class MoneyTypeService : IMoneyTypeService
    {
        private readonly IUnitOfWork _uow;
        public MoneyTypeService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        public async Task<IEnumerable<MoneyType>> GetAllAsync()
        {
            var data = await _uow.MoneyTypeRepository.GetAllAsync(null, x => x.OrderByDescending(x => x.Id));
            return data;
        }

        public async Task<MoneyType> GetByIdAsync(int id)
        {
            var data = await _uow.MoneyTypeRepository.GetByIdAsync(id);
            return data;
        }

        public async Task AddAsync(MoneyType moneyType)
        {
            await _uow.MoneyTypeRepository.AddAsync(moneyType);
            await _uow.CommitAsync();
        }

        public async Task Update(MoneyType moneyType)
        {
            _uow.MoneyTypeRepository.Update(moneyType);
            await _uow.CommitAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _uow.MoneyTypeRepository.DeleteAsync(id);
            await _uow.CommitAsync();
        }

    }
}
