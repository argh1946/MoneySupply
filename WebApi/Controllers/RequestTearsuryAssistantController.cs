using AutoMapper;
using Core.Contracts.Request;
using Core.Contracts.Status;
using Core.DTOs;
using Core.Entities;
using Core.Filter;
using Core.Helper;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RequestTearsuryAssistantController : ControllerBase
    {

        protected readonly IRequestTearsuryAssistantService _requestTearsuryAssistantService;
        private readonly IMapper _mapper;
        private ILogger<RequestTearsuryAssistantController> _logger;


        public RequestTearsuryAssistantController(IRequestTearsuryAssistantService RequestTearsuryAssistantService, IMapper mapper, ILogger<RequestTearsuryAssistantController> logger)
        {
            _requestTearsuryAssistantService = RequestTearsuryAssistantService;
            _mapper = mapper;
            _logger = logger;
        }




    }
}