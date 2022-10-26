using Core.Contracts;
using Core.Contracts.Request;
using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.UseCases
{
    public class RequestTearsuryAssistantService : IRequestTearsuryAssistantService
    {
        private readonly IUnitOfWork _uow;
        public RequestTearsuryAssistantService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        public async Task AddAsync(Entities.Request request)
        {
            await _uow.RequestTearsuryAssistantRepository.AddAsync(request);
            await _uow.CommitAsync();
        }
    }
}