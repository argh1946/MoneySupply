using AutoMapper;
using Core.Contracts.Request;
using Core.Contracts.Status;
using Core.DTOs;
using Core.Entities;
using Core.Filter;
using Core.Helper;
using Core.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RequestMoneySupplyController : ControllerBase
    {

        protected readonly IRequestMoneySupplyService _RequestMoneySupplyService;
        private readonly IMapper _mapper;
        private ILogger<RequestMoneySupplyController> _logger;


        public RequestMoneySupplyController(IRequestMoneySupplyService RequestMoneySupplyService, IMapper mapper, ILogger<RequestMoneySupplyController> logger)
        {
            _RequestMoneySupplyService = RequestMoneySupplyService;
            _mapper = mapper;
            _logger = logger;
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> GetRequestMoneySupply()
        {
            try
            {
                var data = await _RequestMoneySupplyService.GetRequestMoneySupplyAsync();
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
        public async Task<IActionResult> AddRequestAsync(Request request)
        {
            try
            {
                request.LetterNo = int.Parse(ConvertToDateTime.ToPersianDate(DateTime.Now,""));
                request.CreatedDate = DateTime.Now;
                request.Creator = 0;
                request.StatusId = 1;

                await _RequestMoneySupplyService.AddAsync(request);
                var reponse = ResponseHelper.CreateReponse((RequestMoneySupplyVM)null, true, null);
                return Ok(reponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex,"خطا");
                string[] err = { ex.Message + " / " + ex.InnerException?.Message };
                var reponse = ResponseHelper.CreateReponse((RequestMoneySupplyVM)null, false, err);
                return BadRequest(reponse);
            }

        }

    }
}