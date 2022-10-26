using AutoMapper;
using Core.Contracts;
using Core.Contracts.AtmCrs;
using Core.DTOs;
using Core.Entities;
using Core.Helper;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AtmCrsController : ControllerBase
    {
        protected readonly IAtmCrsService _atmCrsService;
        private readonly IMapper _mapper;

        public AtmCrsController(IAtmCrsService atmCrsService, IMapper mapper)
        {
            _atmCrsService = atmCrsService;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public async Task<Result<IEnumerable<AtmCrsVM>>> GetAllAtmCrs()
        {
            var data = await _atmCrsService.GetAllAsync();
            var result = _mapper.Map<IEnumerable<AtmCrs>, IEnumerable<AtmCrsVM>>(data);
            return Result.Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<Result<AtmCrsVM>> GetByIdAtmCrs(int id)
        {
            var data = await _atmCrsService.GetByIdAsync(id);
            var result = _mapper.Map<AtmCrs, AtmCrsVM>(data);
            return Result.Ok(result);
        }

        [HttpPost("[action]")]
        public async Task<Result> AddAtmCrsAsync(AtmCrs atmCrs)
        {
            await _atmCrsService.AddAsync(atmCrs);
            return Result.Ok();
        }

        [HttpPut("[action]")]
        public async Task<Result> UpdateAtmCrs(AtmCrs atmCrs)
        {
            await _atmCrsService.Update(atmCrs);
            return Result.Ok();
        }

        [HttpDelete("[action]")]
        public async Task<Result> DeleteAtmCrsAsync(int id)
        {
            await _atmCrsService.DeleteAsync(id);
            return Result.Ok();
        }
    }
}