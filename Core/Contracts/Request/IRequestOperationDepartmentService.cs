namespace Core.Contracts.Request
{
    public interface IRequestOperationDepartmentService
    {
        Task<IEnumerable<Entities.Request>> GetRequestOperationDepartmentAsync();
        Task ConfirmOperationDepartmentAsync(int requestId, string des);
        Task RejectOperationDepartmentAsync(int requestId, string des);
        Task<IEnumerable<Entities.Request>> GetSettlementOperationDepartmentAsync();
        Task ConfirmSettlementOperationDepartmentAsync(int requestId, string des);
        Task RejectSettlementOperationDepartmentAsync(int requestId, string des);
    }
}