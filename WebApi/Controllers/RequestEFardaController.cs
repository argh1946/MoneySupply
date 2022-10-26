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
    public class RequestEFardaController : ControllerBase
    {
        protected readonly IRequestEFardaService _requestEFardaService;
        private readonly IMapper _mapper;

        public RequestEFardaController(IRequestEFardaService requestEFardaService, IMapper mapper)
        {
            _requestEFardaService = requestEFardaService;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public async Task<Result<IEnumerable<RequestEfardaVM>>> GetRequestEFarda()
        {
            var data = await _requestEFardaService.GetRequestEFardaAsync();
            var result = _mapper.Map<IEnumerable<Request>, IEnumerable<RequestEfardaVM>>(data);
            return Result.Ok(result);
        }

        [HttpPost("[action]")]
        public async Task<Result> ConfrimRequestAsync(int requestId, string des)
        {
            await _requestEFardaService.ConfirmEFardaAsync(requestId, des);
            return Result.Ok();
        }

        [HttpPost("[action]")]
        public async Task<Result> RejectRequestAsync(int requestId, string des)
        {
            await _requestEFardaService.RejectEFardaAsync(requestId, des);
            return Result.Ok();
        }
    }
}