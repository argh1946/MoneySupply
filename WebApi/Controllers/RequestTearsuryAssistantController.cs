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
    public class RequestTearsuryAssistantController : ControllerBase
    {
        protected readonly IRequestTearsuryAssistantService _requestTearsuryAssistantService;
        private readonly IMapper _mapper;
        
        public RequestTearsuryAssistantController(IRequestTearsuryAssistantService RequestTearsuryAssistantService, IMapper mapper)
        {
            _requestTearsuryAssistantService = RequestTearsuryAssistantService;
            _mapper = mapper;
        }

        [HttpPost("[action]")]
        public async Task<Result> AddRequestAsync(RequestTearsuryAssistantInput req)
        {
            var request = _mapper.Map<RequestTearsuryAssistantInput, Request>(req);
            request.LetterNo = int.Parse(ConvertToDateTime.ToPersianDate(DateTime.Now, ""));
            request.CreatedDate = DateTime.Now;
            request.Creator = 0;
            request.StatusId = 1;
            await _requestTearsuryAssistantService.AddAsync(request);
            return Result.Ok();
        }
    }
}