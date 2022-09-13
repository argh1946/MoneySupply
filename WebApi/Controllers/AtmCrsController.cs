using AutoMapper;
using Core.Contracts;
using Core.Contracts.AtmCrs;
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
    public class AtmCrsController : ControllerBase
    {

        protected readonly IAtmCrsService _atmCrsService;
        private readonly IMapper _mapper;

        public AtmCrsController(IAtmCrsService atmCrsService,IMapper mapper)
        {
            _atmCrsService = atmCrsService;
            _mapper = mapper;
            //_logger = logger;
        }
       
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllAtmCrs()
        {
            var data = await _atmCrsService.GetAllAsync();
            var result = _mapper.Map<IEnumerable<AtmCrs>, IEnumerable<AtmCrsVM>>(data);
            //var reponse = PaginationHelper.CreateReponse<AtmCrsVM>(result);
            string[] err = {"", ""};
            var reponse = ResponseHelper.CreateReponse<AtmCrsVM>(result, false,err);
            var aa = 11;
            return Ok(reponse);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAtmCrsPage([FromQuery] PaginationFilter filter)
        {
            var data = await _atmCrsService.GetAllAsync();
            var result = _mapper.Map<IEnumerable<AtmCrs>, IEnumerable<AtmCrsVM>>(data);
            //return new GetAllAtmCrsOutput(true, result);


            var route = Request.Path.Value;
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            //var pagedReponse = PaginationHelper.CreatePagedReponse<AtmCrsVM>(result, validFilter, 10, null, route);

            //return Ok(pagedReponse);
            return Ok();
        }
    }
}