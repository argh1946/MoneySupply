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

        protected readonly IRequestTreasuryAccountantService _requestTreasuryAccountantService;
        private readonly IMapper _mapper;
        private ILogger<RequestTreasuryAccountantController> _logger;


        public RequestTreasuryAccountantController(IRequestTreasuryAccountantService RequestTreasuryAccountantService, IMapper mapper, ILogger<RequestTreasuryAccountantController> logger)
        {
            _requestTreasuryAccountantService = RequestTreasuryAccountantService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetRequestTreasuryAccountant()
        {
            try
            {
                var data = await _requestTreasuryAccountantService.GetRequestTreasuryAccountantAsync();
                var result = _mapper.Map<IEnumerable<Request>, IEnumerable<RequestTreasuryAccountantVM>>(data);
                var reponse = ResponseHelper.CreateReponse(result, true, null);
                return Ok(reponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "خطا");
                string[] err = { ex.Message + " / " + ex.InnerException?.Message };
                var reponse = ResponseHelper.CreateReponse((IEnumerable<RequestTreasuryAccountantVM>)null, false, err);
                return BadRequest(reponse);
            }
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> ConfrimRequestAsync(int requestId, string des)
        {
            try
            {
                await _requestTreasuryAccountantService.ConfirmTreasuryAccountantAsync(requestId, des);
                var reponse = ResponseHelper.CreateReponse((RequestTreasuryAccountantVM)null, true, null);
                return Ok(reponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "خطا");
                string[] err = { ex.Message + " / " + ex.InnerException?.Message };
                var reponse = ResponseHelper.CreateReponse((RequestTreasuryAccountantVM)null, false, err);
                return BadRequest(reponse);
            }

        }

        [HttpPost("[action]")]
        public async Task<IActionResult> RejectRequestAsync(int requestId, string des)
        {
            try
            {
                await _requestTreasuryAccountantService.RejectTreasuryAccountantAsync(requestId, des);
                var reponse = ResponseHelper.CreateReponse((RequestTreasuryAccountantVM)null, true, null);
                return Ok(reponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "خطا");
                string[] err = { ex.Message + " / " + ex.InnerException?.Message };
                var reponse = ResponseHelper.CreateReponse((RequestTreasuryAccountantVM)null, false, err);
                return BadRequest(reponse);
            }

        }



    }
}