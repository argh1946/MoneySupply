namespace Core.Contracts.Request
{
    public interface IRequestTreasuryManagerService
    {
        Task<IEnumerable<Entities.Request>> GetRequestTreasuryManagerAsync();
        Task ConfirmTreasuryManagerAsync(int requestId, string des);
        Task RejectTreasuryManagerAsync(int requestId, string des);
        Task<IEnumerable<Entities.Request>> GetSettlementTreasuryManagerAsync();
        Task ConfirmSettlementTreasuryManagerAsyng(int requestId, string des);
        Task RejectSettlementTreasuryManagerAsync(int requestId, string des);
    }
}