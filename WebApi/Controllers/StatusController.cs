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

        public StatusController(IStatusService StatusService, IMapper mapper)
        {
            _StatusService = StatusService;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllStatus() 
        {
            var a = 0;
            var data = await _StatusService.GetAllAsync();
            var result = _mapper.Map<IEnumerable<Status>, IEnumerable<StatusVM>>(data);
            var response = ResponseHelper.CreateReponse(result, true, null);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdStatus(int id)
        {
            var data = await _StatusService.GetByIdAsync(id);
            var result = _mapper.Map<Status, StatusVM>(data);
            var response = ResponseHelper.CreateReponse(result, true, null);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddStatusAsync(Status Status)
        {
            await _StatusService.AddAsync(Status);
            var response = ResponseHelper.CreateReponse((StatusVM)null, true, null);
            return Ok(response);
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateStatus(Status Status)
        {
            await _StatusService.Update(Status);
            var response = ResponseHelper.CreateReponse((StatusVM)null, true, null);
            return Ok(response);
        }

        [HttpDelete("[action]")]
        public async Task<IActionResult> DeleteStatusAsync(int id)
        {
            await _StatusService.DeleteAsync(id);
            var response = ResponseHelper.CreateReponse((StatusVM)null, true, null);
            return Ok(response);
        }
    }
}