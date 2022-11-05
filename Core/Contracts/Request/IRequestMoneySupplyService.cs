namespace Core.Contracts.Request
{
    public interface IRequestMoneySupplyService
    {
        Task AddAsync(Entities.Request request);
        Task AddWithFileAsync(Entities.Request request);
        Task Update(Entities.Request request);
        Task DeleteAsync(int id);
        Task<Entities.Request> GetByIdAsync(int id);
        Task<IEnumerable<Entities.Request>> GetSettlementMoneySupplyAsync();
        Task ConfirmSettlementMoneySupplyAsync(int requestId, string des);
        Task RejectSettlementMoneySupplyAsync(int requestId, string des);
    }
}