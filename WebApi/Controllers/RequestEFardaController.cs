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
    public class RequestEFardaController : ControllerBase
    {

        protected readonly IRequestEFardaService _requestEFardaService;
        private readonly IMapper _mapper;
        private ILogger<RequestEFardaController> _logger;


        public RequestEFardaController(IRequestEFardaService requestEFardaService, IMapper mapper, ILogger<RequestEFardaController> logger)
        {
            _requestEFardaService = requestEFardaService;
            _mapper = mapper;
            _logger = logger;
        }

        

       
    }
}