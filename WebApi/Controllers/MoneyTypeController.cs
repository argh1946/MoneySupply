using AutoMapper;
using Core.Contracts.MoneyType;
using Core.DTOs;
using Core.Entities;
using Core.Filter;
using Core.Helper;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoneyTypeController : ControllerBase
    {

        protected readonly IMoneyTypeService _MoneyTypeService;
        private readonly IMapper _mapper;
        private ILogger<MoneyTypeController> _logger;


        public MoneyTypeController(IMoneyTypeService MoneyTypeService, IMapper mapper, ILogger<MoneyTypeController> logger)
        {
            _MoneyTypeService = MoneyTypeService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllMoneyType()
        {
            try
            {
                var data = await _MoneyTypeService.GetAllAsync();
                var result = _mapper.Map<IEnumerable<MoneyType>, IEnumerable<MoneyTypeVM>>(data);
                string[] err = { "" };
                var reponse = ResponseHelper.CreateReponse(result, true, err);
                return Ok(reponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "خطا");
                string[] err = { ex.Message };
                var reponse = ResponseHelper.CreateReponse((IEnumerable<MoneyTypeVM>)null, false, err );
                return BadRequest(reponse);
            }       
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdMoneyType(int id)
        {
            try
            {
                var data = await _MoneyTypeService.GetByIdAsync(id);
                var result = _mapper.Map<MoneyType, MoneyTypeVM>(data);
                string[] err = { "" };
                var reponse = ResponseHelper.CreateReponse(result, true, err);
                return Ok(reponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "خطا");
                string[] err = { ex.Message };
                var reponse = ResponseHelper.CreateReponse((MoneyTypeVM)null, false, err);
                return BadRequest(reponse);
            }
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddMoneyTypeAsync(MoneyType moneyType)
        {
            try
            {
                await _MoneyTypeService.AddAsync(moneyType);
                string[] err = { "" };
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
            
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateMoneyType(MoneyType moneyType)
        {
            try
            {
                await _MoneyTypeService.Update(moneyType);
                string[] err = { "" };
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return NotFound();
            }

        }

        [HttpDelete("[action]")]
        public async Task<IActionResult> DeleteMoneyTypeAsync(int id)
        {
            try
            {
                await _MoneyTypeService.DeleteAsync(id);
                string[] err = { "" };
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return NotFound();
            }

        }
    }
}