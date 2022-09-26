using AutoMapper;
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
    public class StatusController : ControllerBase
    {

        protected readonly IStatusService _StatusService;
        private readonly IMapper _mapper;
        private ILogger<StatusController> _logger;


        public StatusController(IStatusService StatusService, IMapper mapper, ILogger<StatusController> logger)
        {
            _StatusService = StatusService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllStatus()
        {
            try
            {
                var data = await _StatusService.GetAllAsync();
                var result = _mapper.Map<IEnumerable<Status>, IEnumerable<StatusVM>>(data);
                var response = ResponseHelper.CreateReponse(result, true, null);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "خطا");
                string[] err = { ex.Message + " / " + ex.InnerException?.Message };
                var response = ResponseHelper.CreateReponse((IEnumerable<StatusVM>)null, false, err);
                return BadRequest(response);
            }
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdStatus(int id)
        {
            try
            {
                var data = await _StatusService.GetByIdAsync(id);
                var result = _mapper.Map<Status, StatusVM>(data);
                var response = ResponseHelper.CreateReponse(result, true, null);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "خطا");
                string[] err = { ex.Message + " / " + ex.InnerException?.Message };
                var response = ResponseHelper.CreateReponse((StatusVM)null, false, err);
                return BadRequest(response);
            }
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddStatusAsync(Status Status)
        {
            try
            {
                await _StatusService.AddAsync(Status);
                var response = ResponseHelper.CreateReponse((StatusVM)null, true, null);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "خطا");
                string[] err = { ex.Message + " / " + ex.InnerException?.Message };
                var response = ResponseHelper.CreateReponse((StatusVM)null, false, err);
                return BadRequest(response);
            }

        }

        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateStatus(Status Status)
        {
            try
            {
                await _StatusService.Update(Status);
                var response = ResponseHelper.CreateReponse((StatusVM)null, true, null);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "خطا");
                string[] err = { ex.Message + " / " + ex.InnerException?.Message };
                var reponse = ResponseHelper.CreateReponse((StatusVM)null, false, err);
                return BadRequest(reponse);
            }

        }

        [HttpDelete("[action]")]
        public async Task<IActionResult> DeleteStatusAsync(int id)
        {
            try
            {
                await _StatusService.DeleteAsync(id);
                var response = ResponseHelper.CreateReponse((StatusVM)null, true, null);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "خطا");
                string[] err = { ex.Message + " / " + ex.InnerException?.Message };
                var reponse = ResponseHelper.CreateReponse((StatusVM)null, false, err);
                return BadRequest(reponse);
            }

        }
    }
}