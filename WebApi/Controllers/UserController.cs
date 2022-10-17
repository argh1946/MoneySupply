using AutoMapper;
using Core.Contracts;
using Core.Contracts.AtmCrs;
using Core.Contracts.User;
using Core.DTOs;
using Core.Entities;
using Core.Filter;
using Core.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        protected readonly IUserService _userService;


        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllAtmCrs()
        {

            var data = await _userService.GetAllAsync();
            // var result = _mapper.Map<IEnumerable<AtmCrs>, IEnumerable<AtmCrsVM>>(data);
            var reponse = ResponseHelper.CreateReponse(data, true, null);
            return Ok(reponse);

        }


    }
}