using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Request
{
    public interface IRequestOperationDepartmentService
    {
        Task<IEnumerable<Entities.Request>> GetRequestOperationDepartmentAsync();
        Task ConfirmOperationDepartmentAsync(int requestId, string des);
        Task RejectOperationDepartmentAsync(int requestId, string des);
    }
}
