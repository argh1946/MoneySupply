using AutoMapper;
using Core.Contracts;
using Core.Contracts.Branch;
using Core.DTOs;
using Core.Entities;
using Core.Helper;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BranchController : ControllerBase
    {
        protected readonly IBranchService _BranchService;
        private readonly IMapper _mapper;

        public BranchController(IBranchService BranchService, IMapper mapper)
        {
            _BranchService = BranchService;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public async Task<Result<IEnumerable<BranchVM>>> GetAllBranch()
        {
            var data = await _BranchService.GetAll();
            var result = _mapper.Map<IEnumerable<Branch>, IEnumerable<BranchVM>>(data);
            return Result.Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<Result<BranchVM>> GetByIdBranchType(int id)
        {
            var data = await _BranchService.GetByIdAsync(id);
            var result = _mapper.Map<Branch, BranchVM>(data);
            return Result.Ok(result);
        }
    }
}