namespace Core.Contracts.Request
{
    public interface IRequestEFardaService
    {
        Task<IEnumerable<Entities.Request>> GetRequestEFardaAsync();
        Task ConfirmEFardaAsync(int requestId, string des);
        Task RejectEFardaAsync(int requestId, string des);
    }
}