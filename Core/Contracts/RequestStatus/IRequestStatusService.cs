using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.RequestStatus
{
    public interface IRequestStatusService
    {
        Task<IEnumerable<Entities.RequestStatus>> GetAllAsync();
        Task<Entities.RequestStatus> GetByIdAsync(int id);
        Task AddAsync(Entities.RequestStatus requestStatus);
        Task Update(Entities.RequestStatus requestStatus);
        Task DeleteAsync(int id);
    }
}
