using AutoMapper;
using Core.Contracts;
using Core.Contracts.FileAttachment;
using Core.Contracts.Request;
using Core.DTOs;
using Core.Entities;
using Core.Helper;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RequestMoneySupplyController : ControllerBase
    {
        private readonly IRequestMoneySupplyService _requestMoneySupplyService;
        private readonly IFileAttachmentService _fileAttachmentService;
        private readonly IMapper _mapper;

        public RequestMoneySupplyController(IRequestMoneySupplyService requestMoneySupplyService, IFileAttachmentService fileAttachmentService, IMapper mapper)
        {
            _requestMoneySupplyService = requestMoneySupplyService;
            _mapper = mapper;
            _fileAttachmentService = fileAttachmentService;
        }

        [HttpPost("[action]")]
        public async Task<Result> FileUpload(ICollection<IFormFile> files, int requestId)
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
                    item.FileTypeId = 1;
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
            return Result.Ok();
        }

        [HttpPost("[action]")]
        public async Task<Result> AddRequestAsync(RequestMoneySupplyInput req)
        {
            var request = _mapper.Map<RequestMoneySupplyInput, Request>(req);
            request.LetterNo = int.Parse(ConvertToDateTime.ToPersianDate(DateTime.Now, ""));
            request.CreatedDate = DateTime.Now;
            request.Creator = 0;
            request.StatusId = 1;
            await _requestMoneySupplyService.AddAsync(request);
            return Result.Ok();
        }

        #region پول گذاری
        [HttpGet("[action]")]
        public async Task<Result<IEnumerable<RequestMoneySupplyVM>>> GetRequestMoneySupply()
        {
                var data = await _requestMoneySupplyService.GetSettlementMoneySupplyAsync();
                var result = _mapper.Map<IEnumerable<Request>, IEnumerable<RequestMoneySupplyVM>>(data);
                return Result.Ok(result);
        }

        [HttpPost("[action]")]
        public async Task<Result> ConfirmRequestAsync(int requestId, string des)
        {
            await _requestMoneySupplyService.ConfirmSettlementMoneySupplyAsync(requestId, des);
            return Result.Ok();
        }

        [HttpPost("[action]")]
        public async Task<Result> RejectRequestAsync(int requestId, string des)
        {
            await _requestMoneySupplyService.RejectSettlementMoneySupplyAsync(requestId, des);
            return Result.Ok();
        }
        #endregion
    }
}