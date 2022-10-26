namespace Core.Contracts.MoneyType
{
    public interface IMoneyTypeService
    {
        Task<IEnumerable<Entities.MoneyType>> GetAllAsync();
        Task<Entities.MoneyType> GetByIdAsync(int id);
        Task AddAsync(Entities.MoneyType moneyType);
        Task Update(Entities.MoneyType moneyType);
        Task DeleteAsync(int id);
    }
}