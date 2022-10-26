using AutoMapper;
using Core.Contracts;
using Core.Contracts.Request;
using Core.DTOs;
using Core.Entities;
using Core.Helper;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RequestTreasuryManagerController : ControllerBase
    {
        protected readonly IRequestTreasuryManagerService _requestTreasuryManagerService;
        private readonly IMapper _mapper;

        public RequestTreasuryManagerController(IRequestTreasuryManagerService RequestTreasuryManagerService, IMapper mapper)
        {
            _requestTreasuryManagerService = RequestTreasuryManagerService;
            _mapper = mapper;
        }

        #region پول گذاری
        [HttpGet("[action]")]
        public async Task<Result<IEnumerable<RequestTreasuryManagerVM>>> GetRequestTreasuryManager()
        {
            var data = await _requestTreasuryManagerService.GetRequestTreasuryManagerAsync();
            var result = _mapper.Map<IEnumerable<Request>, IEnumerable<RequestTreasuryManagerVM>>(data);
            return Result.Ok(result);
        }

        [HttpPost("[action]")]
        public async Task<Result> ConfrimRequestAsync(int requestId, string des)
        {
            await _requestTreasuryManagerService.ConfirmTreasuryManagerAsync(requestId, des);
            return Result.Ok();
        }

        [HttpPost("[action]")]
        public async Task<Result> RejectRequestAsync(int requestId, string des)
        {
            await _requestTreasuryManagerService.RejectTreasuryManagerAsync(requestId, des);
            return Result.Ok();
        }
        #endregion

        #region تسویه
        [HttpGet("[action]")]
        public async Task<Result<IEnumerable<RequestTreasuryManagerVM>>> GetSettlementTreasuryManager()
        {
            var data = await _requestTreasuryManagerService.GetSettlementTreasuryManagerAsync();
            var result = _mapper.Map<IEnumerable<Request>, IEnumerable<RequestTreasuryManagerVM>>(data);
            return Result.Ok(result);
        }

        [HttpPost("[action]")]
        public async Task<Result> ConfrimSettlementRequestAsync(int requestId, string des)
        {
            await _requestTreasuryManagerService.ConfirmSettlementTreasuryManagerAsyng(requestId, des);
            return Result.Ok();
        }

        [HttpPost("[action]")]
        public async Task<Result> RejectSettlementRequestAsync(int requestId, string des)
        {
            await _requestTreasuryManagerService.RejectSettlementTreasuryManagerAsync(requestId, des);
            return Result.Ok();
        }
        #endregion
    }
}