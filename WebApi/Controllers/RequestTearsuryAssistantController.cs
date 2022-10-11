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

        [HttpGet("[action]")]
        public async Task<IActionResult> GetRequestTearsuryAssistant()
        {
            try
            {
                var data = await _requestTearsuryAssistantService.GetTearsuryAssistantAsync();
                var result = _mapper.Map<IEnumerable<Request>, IEnumerable<RequestMoneySupplyVM>>(data);
                var reponse = ResponseHelper.CreateReponse(result, true, null);
                return Ok(reponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "خطا");
                string[] err = { ex.Message + " / " + ex.InnerException?.Message };
                var reponse = ResponseHelper.CreateReponse((IEnumerable<RequestMoneySupplyVM>)null, false, err);
                return BadRequest(reponse);
            }
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> UpdateRequestAsync(RequestTearsuryAssistantInput req, string des)
        {
            try
            {
                var request = _mapper.Map<RequestTearsuryAssistantInput, Request>(req);
                await _requestTearsuryAssistantService.UpdateTearsuryAssistantAsync(request, des);
                var reponse = ResponseHelper.CreateReponse((RequestEfardaVM)null, true, null);
                return Ok(reponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "خطا");
                string[] err = { ex.Message + " / " + ex.InnerException?.Message };
                var reponse = ResponseHelper.CreateReponse((RequestEfardaVM)null, false, err);
                return BadRequest(reponse);
            }

        }

        


    }
}