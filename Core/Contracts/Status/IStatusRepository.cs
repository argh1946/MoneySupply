
using Core.Helper;

namespace Core.Contracts.Status
{
    public interface IStatusRepository : IAsyncGenericRepository<Entities.Status>
    {
        Task<PaginatedList<Entities.Status>> GetAllPagedAsync();
    }
}
