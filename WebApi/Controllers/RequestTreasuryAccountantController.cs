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
    public class RequestTreasuryAccountantController : ControllerBase
    {
        protected readonly IRequestTreasuryAccountantService _requestTreasuryAccountantService;
        private readonly IMapper _mapper;

        public RequestTreasuryAccountantController(IRequestTreasuryAccountantService RequestTreasuryAccountantService, IMapper mapper)
        {
            _requestTreasuryAccountantService = RequestTreasuryAccountantService;
            _mapper = mapper;
        }

        #region پول گذاری
        [HttpGet("[action]")]
        public async Task<Result<IEnumerable<RequestTreasuryAccountantVM>>> GetRequestTreasuryAccountant()
        {
            var data = await _requestTreasuryAccountantService.GetRequestTreasuryAccountantAsync();
            var result = _mapper.Map<IEnumerable<Request>, IEnumerable<RequestTreasuryAccountantVM>>(data);
            return Result.Ok(result);
        }

        [HttpPost("[action]")]
        public async Task<Result> ConfrimRequestAsync(int requestId, string des)
        {
            await _requestTreasuryAccountantService.ConfirmTreasuryAccountantAsync(requestId, des);
            return Result.Ok();
        }

        [HttpPost("[action]")]
        public async Task<Result> RejectRequestAsync(int requestId, string des)
        {
            await _requestTreasuryAccountantService.RejectTreasuryAccountantAsync(requestId, des);
            return Result.Ok();
        }
        #endregion

        #region تسویه
        [HttpGet("[action]")]
        public async Task<Result<IEnumerable<RequestTreasuryAccountantVM>>> GetSettlementTreasuryAccountant()
        {
            var data = await _requestTreasuryAccountantService.GetRequestTreasuryAccountantAsync();
            var result = _mapper.Map<IEnumerable<Request>, IEnumerable<RequestTreasuryAccountantVM>>(data);
            return Result.Ok(result);
        }

        [HttpPost("[action]")]
        public async Task<Result> ConfrimSettlementRequestAsync(int requestId, string des)
        {
            await _requestTreasuryAccountantService.ConfirmSettlementTreasuryAccountantAsync(requestId, des);
            return Result.Ok();
        }

        [HttpPost("[action]")]
        public async Task<Result> RejectSettlementRequestAsync(int requestId, string des)
        {
            await _requestTreasuryAccountantService.RejectSettlementTreasuryAccountantAsync(requestId, des);
            return Result.Ok();
        }
        #endregion
    }
}