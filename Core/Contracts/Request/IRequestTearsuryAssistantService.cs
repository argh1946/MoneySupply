using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Request
{
    public interface IRequestTearsuryAssistantService
    {
        Task<IEnumerable<Entities.Request>> GetTearsuryAssistantAsync();
        Task UpdateTearsuryAssistantAsync(Entities.Request request, string des);
    }
}
