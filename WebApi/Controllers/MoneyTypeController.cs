using AutoMapper;
using Core.Contracts;
using Core.Contracts.MoneyType;
using Core.DTOs;
using Core.Entities;
using Core.Helper;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoneyTypeController : ControllerBase
    {
        protected readonly IMoneyTypeService _MoneyTypeService;
        private readonly IMapper _mapper;

        public MoneyTypeController(IMoneyTypeService MoneyTypeService, IMapper mapper)
        {
            _MoneyTypeService = MoneyTypeService;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public async Task<Result<IEnumerable<MoneyTypeVM>>> GetAllMoneyType()
        {
            var data = await _MoneyTypeService.GetAllAsync();
            var result = _mapper.Map<IEnumerable<MoneyType>, IEnumerable<MoneyTypeVM>>(data);
            return Result.Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<Result<MoneyTypeVM>> GetByIdMoneyType(int id)
        {
            var data = await _MoneyTypeService.GetByIdAsync(id);
            var result = _mapper.Map<MoneyType, MoneyTypeVM>(data);
            return Result.Ok(result);
        }

        [HttpPost("[action]")]
        public async Task<Result> AddMoneyTypeAsync(MoneyType moneyType)
        {
            await _MoneyTypeService.AddAsync(moneyType);
            return Result.Ok();
        }

        [HttpPut("[action]")]
        public async Task<Result> UpdateMoneyType(MoneyType moneyType)
        {
            await _MoneyTypeService.Update(moneyType);
            return Result.Ok();
        }

        [HttpDelete("[action]")]
        public async Task<Result> DeleteMoneyTypeAsync(int id)
        {
            await _MoneyTypeService.DeleteAsync(id);
            return Result.Ok();
        }
    }
}