namespace Core.Contracts.Request
{
    public interface IRequestTreasuryAccountantService
    {
        Task<IEnumerable<Entities.Request>> GetRequestTreasuryAccountantAsync();
        Task ConfirmTreasuryAccountantAsync(int requestId, string des);
        Task RejectTreasuryAccountantAsync(int requestId, string des);
        Task<IEnumerable<Entities.Request>> GetSettlementTreasuryAccountantAsync();
        Task ConfirmSettlementTreasuryAccountantAsync(int requestId, string des);
        Task RejectSettlementTreasuryAccountantAsync(int requestId, string des);
    }
}