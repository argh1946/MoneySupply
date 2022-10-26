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
    public class RequestOperationDepartmentController : ControllerBase
    {
        protected readonly IRequestOperationDepartmentService _requestOperationDepartmentService;
        private readonly IMapper _mapper;

        public RequestOperationDepartmentController(IRequestOperationDepartmentService RequestOperationDepartmentService, IMapper mapper)
        {
            _requestOperationDepartmentService = RequestOperationDepartmentService;
            _mapper = mapper;
        }

        #region پول گذاری
        [HttpGet("[action]")]
        public async Task<Result<IEnumerable<RequestOperationDepartmentVM>>> GetRequestOperationDepartment()
        {
            var data = await _requestOperationDepartmentService.GetRequestOperationDepartmentAsync();
            var result = _mapper.Map<IEnumerable<Request>, IEnumerable<RequestOperationDepartmentVM>>(data);
            return Result.Ok(result);
        }

        [HttpPost("[action]")]
        public async Task<Result> ConfrimRequestAsync(int requestId, string des)
        {
            await _requestOperationDepartmentService.ConfirmOperationDepartmentAsync(requestId, des);
            return Result.Ok();
        }

        [HttpPost("[action]")]
        public async Task<Result> RejectRequestAsync(int requestId, string des)
        {
            await _requestOperationDepartmentService.RejectOperationDepartmentAsync(requestId, des);
            return Result.Ok();
        }
        #endregion

        #region تسویه
        [HttpGet("[action]")]
        public async Task<Result<IEnumerable<RequestOperationDepartmentVM>>> GetRequestSettlementOperationDepartment()
        {
            var data = await _requestOperationDepartmentService.GetSettlementOperationDepartmentAsync();
            var result = _mapper.Map<IEnumerable<Request>, IEnumerable<RequestOperationDepartmentVM>>(data);
            return Result.Ok(result);
        }

        [HttpPost("[action]")]
        public async Task<Result> ConfirmSettlementRequestAsync(int requestId, string des)
        {
            await _requestOperationDepartmentService.ConfirmSettlementOperationDepartmentAsync(requestId, des);
            return Result.Ok();
        }

        [HttpPost("[action]")]
        public async Task<Result> RejectSettlementRequestAsync(int requestId, string des)
        {
            await _requestOperationDepartmentService.RejectSettlementOperationDepartmentAsync(requestId, des);
            return Result.Ok();
        }
        #endregion
    }
}