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

        protected readonly IRequestTreasuryManagerService _requestTreasuryManagerService;
        private readonly IMapper _mapper;
        private ILogger<RequestTreasuryManagerController> _logger;


        public RequestTreasuryManagerController(IRequestTreasuryManagerService RequestTreasuryManagerService, IMapper mapper, ILogger<RequestTreasuryManagerController> logger)
        {
            _requestTreasuryManagerService = RequestTreasuryManagerService;
            _mapper = mapper;
            _logger = logger;
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> GetRequestTreasuryManager()
        {
            try
            {
                var data = await _requestTreasuryManagerService.GetRequestTreasuryManagerAsync();
                var result = _mapper.Map<IEnumerable<Request>, IEnumerable<RequestTreasuryManagerVM>>(data);
                var reponse = ResponseHelper.CreateReponse(result, true, null);
                return Ok(reponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "خطا");
                string[] err = { ex.Message + " / " + ex.InnerException?.Message };
                var reponse = ResponseHelper.CreateReponse((IEnumerable<RequestTreasuryManagerVM>)null, false, err);
                return BadRequest(reponse);
            }
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> ConfrimRequestAsync(int requestId, string des)
        {
            try
            {
                await _requestTreasuryManagerService.ConfirmTreasuryManagerAsync(requestId, des);
                var reponse = ResponseHelper.CreateReponse((RequestTreasuryManagerVM)null, true, null);
                return Ok(reponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "خطا");
                string[] err = { ex.Message + " / " + ex.InnerException?.Message };
                var reponse = ResponseHelper.CreateReponse((RequestTreasuryManagerVM)null, false, err);
                return BadRequest(reponse);
            }

        }

        [HttpPost("[action]")]
        public async Task<IActionResult> RejectRequestAsync(int requestId, string des)
        {
            try
            {
                await _requestTreasuryManagerService.RejectTreasuryManagerAsync(requestId, des);
                var reponse = ResponseHelper.CreateReponse((RequestTreasuryManagerVM)null, true, null);
                return Ok(reponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "خطا");
                string[] err = { ex.Message + " / " + ex.InnerException?.Message };
                var reponse = ResponseHelper.CreateReponse((RequestTreasuryManagerVM)null, false, err);
                return BadRequest(reponse);
            }

        }




    }
}