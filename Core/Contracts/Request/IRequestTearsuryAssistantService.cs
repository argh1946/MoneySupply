namespace Core.Contracts.Request
{
    public interface IRequestTearsuryAssistantService
    {
        Task AddAsync(Entities.Request request);
    }
}