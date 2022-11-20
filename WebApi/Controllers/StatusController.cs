using AutoMapper;
using Core.Contracts;
using Core.Contracts.Status;
using Core.DTOs;
using Core.Entities;
using Core.Helper;
using FluentResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UML;

namespace WebApi.Controllers
{
   // [AllowAnonymous]
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

        //[NeedPermission(UserPermission.FullAccess)]
        //[AllowAnonymous]
        [HttpGet("[action]")]
        public async Task<Result<PaginatedList<Status>>> GetAllPagedAsync()
        {
            Core.Helper.CommonHelper.CurrentUserBranchCode1();

            var user = Core.Helper.CommonHelper.CurrentUserBranchCode;
            var data = await _StatusService.GetAllPagedAsync();
            //var result = _mapper.Map<IEnumerable<PaginatedList<Status>>, IEnumerable<StatusVM>>(data);
            return Result.Ok(data);
        }


        [HttpGet("[action]")]
        public async Task<Result<IEnumerable<StatusVM>>> GetAllStatus()
        {
            var data = await _StatusService.GetAllAsync();
            var result = _mapper.Map<IEnumerable<Status>, IEnumerable<StatusVM>>(data);
            return Result.Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<Result<StatusVM>> GetByIdStatus(int id)
        {
            var data = await _StatusService.GetByIdAsync(id);
            var result = _mapper.Map<Status, StatusVM>(data);
            return Result.Ok(result);
        }

        [HttpPost("[action]")]
        public async Task<Result> AddStatusAsync(Status Status)
        {
            await _StatusService.AddAsync(Status);
            return Result.Ok();
        }

        [HttpPut("[action]")]
        public async Task<Result> UpdateStatus(Status Status)
        {
            await _StatusService.Update(Status);
            return Result.Ok();
        }

        [HttpDelete("[action]")]
        public async Task<Result> DeleteStatusAsync(int id)
        {
            await _StatusService.DeleteAsync(id);
            return Result.Ok();
        }
    }
}