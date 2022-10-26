
namespace Core.Contracts.Status
{
    public interface IStatusService
    {
        Task<IEnumerable<Entities.Status>> GetAllAsync();
        Task<Entities.Status> GetByIdAsync(int id);
        Task AddAsync(Entities.Status status);
        Task Update(Entities.Status status);
        Task DeleteAsync(int id);
    }
}
