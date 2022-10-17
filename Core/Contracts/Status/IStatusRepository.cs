
namespace Core.Contracts.Status
{
    public interface IStatusRepository : IAsyncGenericRepository<Entities.Status>
    {
        Task<Entities.Status> GetSPByIdAsync(int id);

    }
}
