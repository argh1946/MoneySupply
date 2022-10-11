using AutoMapper;
using Core.Contracts.FileAttachment;
using Core.Contracts.Request;
using Core.Contracts.Status;
using Core.DTOs;
using Core.Entities;
using Core.Filter;
using Core.Helper;
using Core.UseCases;
using Microsoft.AspNetCore.Mvc;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RequestMoneySupplyController : ControllerBase
    {
        private readonly IRequestMoneySupplyService _requestMoneySupplyService;
        private readonly IFileAttachmentService _fileAttachmentService;
        private readonly IMapper _mapper;
        private readonly ILogger<RequestMoneySupplyController> _logger;
        private readonly IWebHostEnvironment _environment;

        public RequestMoneySupplyController(IRequestMoneySupplyService requestMoneySupplyService, IFileAttachmentService fileAttachmentService, IMapper mapper, 
            ILogger<RequestMoneySupplyController> logger, IWebHostEnvironment environment)
        {
            _requestMoneySupplyService = requestMoneySupplyService;
            _mapper = mapper;
            _logger = logger;
            _environment = environment;
            _fileAttachmentService = fileAttachmentService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> FileUpload(ICollection<IFormFile> files,int requestId)
        {
            try
            {
                //ذخیره سازی فایلی
                //var uploads = Path.Combine(_environment.WebRootPath, "uploads");
                //using (var fileStream = new FileStream(Path.Combine(uploads, file.FileName), FileMode.Create))
                //{
                //    await file.CopyToAsync(fileStream);
                //}
                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        FileAttachment item = new FileAttachment();
                        item.Title = file.FileName;
                        item.RequestId = requestId;
                        item.FileType = 1;
                        using (var ms = new MemoryStream())
                        {
                            await file.CopyToAsync(ms);
                            var fileBytes = ms.ToArray();
                            //string s = Convert.ToBase64String(fileBytes);
                            item.FileArrey = fileBytes;
                        }
                        await _fileAttachmentService.AddAsync(item);
                    }
                }
                var reponse = ResponseHelper.CreateReponse((FileAttachment)null, true, null);
                return Ok(reponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "خطا");
                string[] err = { ex.Message + " / " + ex.InnerException?.Message };
                var reponse = ResponseHelper.CreateReponse((FileAttachment)null, false, err);
                return BadRequest(reponse);
            }
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetRequestMoneySupply()
        {
            try
            {
                var data = await _requestMoneySupplyService.GetRequestMoneySupplyAsync();
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
        public async Task<IActionResult> AddRequestAsync(RequestMoneySupplyInput req)
        {
            try
            {
                var request = _mapper.Map<RequestMoneySupplyInput, Request>(req);
                request.LetterNo = int.Parse(ConvertToDateTime.ToPersianDate(DateTime.Now,""));
                request.CreatedDate = DateTime.Now;
                request.Creator = 0;
                request.StatusId = 1;

                await _requestMoneySupplyService.AddAsync(request);
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