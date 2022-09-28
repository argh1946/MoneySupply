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

        protected readonly IRequestOperationDepartmentService _requestOperationDepartmentService;
        private readonly IMapper _mapper;
        private ILogger<RequestOperationDepartmentController> _logger;


        public RequestOperationDepartmentController(IRequestOperationDepartmentService RequestOperationDepartmentService, IMapper mapper, ILogger<RequestOperationDepartmentController> logger)
        {
            _requestOperationDepartmentService = RequestOperationDepartmentService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetRequestOperationDepartment()
        {
            try
            {
                var data = await _requestOperationDepartmentService.GetRequestOperationDepartmentAsync();
                var result = _mapper.Map<IEnumerable<Request>, IEnumerable<RequestOperationDepartmentVM>>(data);
                var reponse = ResponseHelper.CreateReponse(result, true, null);
                return Ok(reponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "خطا");
                string[] err = { ex.Message + " / " + ex.InnerException?.Message };
                var reponse = ResponseHelper.CreateReponse((IEnumerable<RequestOperationDepartmentVM>)null, false, err);
                return BadRequest(reponse);
            }
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> ConfrimRequestAsync(int requestId, string des)
        {
            try
            {
                await _requestOperationDepartmentService.ConfirmOperationDepartmentAsync(requestId, des);
                var reponse = ResponseHelper.CreateReponse((RequestOperationDepartmentVM)null, true, null);
                return Ok(reponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "خطا");
                string[] err = { ex.Message + " / " + ex.InnerException?.Message };
                var reponse = ResponseHelper.CreateReponse((RequestOperationDepartmentVM)null, false, err);
                return BadRequest(reponse);
            }

        }

        [HttpPost("[action]")]
        public async Task<IActionResult> RejectRequestAsync(int requestId, string des)
        {
            try
            {
                await _requestOperationDepartmentService.RejectOperationDepartmentAsync(requestId, des);
                var reponse = ResponseHelper.CreateReponse((RequestOperationDepartmentVM)null, true, null);
                return Ok(reponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "خطا");
                string[] err = { ex.Message + " / " + ex.InnerException?.Message };
                var reponse = ResponseHelper.CreateReponse((RequestOperationDepartmentVM)null, false, err);
                return BadRequest(reponse);
            }

        }



    }
}