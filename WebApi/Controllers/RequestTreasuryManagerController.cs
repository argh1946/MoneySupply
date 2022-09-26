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
    public class RequestTreasuryManagerController : ControllerBase
    {

        protected readonly IRequestTreasuryManagerService _RequestTreasuryManagerService;
        private readonly IMapper _mapper;
        private ILogger<RequestTreasuryManagerController> _logger;


        public RequestTreasuryManagerController(IRequestTreasuryManagerService RequestTreasuryManagerService, IMapper mapper, ILogger<RequestTreasuryManagerController> logger)
        {
            _RequestTreasuryManagerService = RequestTreasuryManagerService;
            _mapper = mapper;
            _logger = logger;
        }




    }
}