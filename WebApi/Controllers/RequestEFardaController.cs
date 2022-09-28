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

        [HttpGet("[action]")]
        public async Task<IActionResult> GetRequestEFarda()
        {
            try
            {
                var data = await _requestEFardaService.GetRequestEFardaAsync();
                var result = _mapper.Map<IEnumerable<Request>, IEnumerable<RequestEfardaVM>>(data);
                var reponse = ResponseHelper.CreateReponse(result, true, null);
                return Ok(reponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "خطا");
                string[] err = { ex.Message + " / " + ex.InnerException?.Message };
                var reponse = ResponseHelper.CreateReponse((IEnumerable<RequestEfardaVM>)null, false, err);
                return BadRequest(reponse);
            }
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> ConfrimRequestAsync(int requestId,string des)
        {
            try
            {
                await _requestEFardaService.ConfirmEFardaAsync(requestId,des);
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

        [HttpPost("[action]")]
        public async Task<IActionResult> RejectRequestAsync(int requestId, string des)
        {
            try
            {
                await _requestEFardaService.RejectEFardaAsync(requestId, des);
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