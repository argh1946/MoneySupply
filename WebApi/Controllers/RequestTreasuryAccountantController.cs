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
    public class RequestTreasuryAccountantController : ControllerBase
    {

        protected readonly IRequestTreasuryAccountantService _RequestTreasuryAccountantService;
        private readonly IMapper _mapper;
        private ILogger<RequestTreasuryAccountantController> _logger;


        public RequestTreasuryAccountantController(IRequestTreasuryAccountantService RequestTreasuryAccountantService, IMapper mapper, ILogger<RequestTreasuryAccountantController> logger)
        {
            _RequestTreasuryAccountantService = RequestTreasuryAccountantService;
            _mapper = mapper;
            _logger = logger;
        }




    }
}