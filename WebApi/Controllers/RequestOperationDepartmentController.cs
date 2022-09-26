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
    public class RequestOperationDepartmentController : ControllerBase
    {

        protected readonly IRequestOperationDepartmentService _RequestOperationDepartmentService;
        private readonly IMapper _mapper;
        private ILogger<RequestOperationDepartmentController> _logger;


        public RequestOperationDepartmentController(IRequestOperationDepartmentService RequestOperationDepartmentService, IMapper mapper, ILogger<RequestOperationDepartmentController> logger)
        {
            _RequestOperationDepartmentService = RequestOperationDepartmentService;
            _mapper = mapper;
            _logger = logger;
        }




    }
}