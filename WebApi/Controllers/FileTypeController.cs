using AutoMapper;
using Core.Contracts;
using Core.Contracts.FileType;
using Core.DTOs;
using Core.Entities;
using Core.Helper;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileTypeController : ControllerBase
    {
        protected readonly IFileTypeService _fileTypeService;
        private readonly IMapper _mapper;

        public FileTypeController(IFileTypeService fileTypeService, IMapper mapper)
        {
            _fileTypeService = fileTypeService;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public async Task<Result<IEnumerable<FileTypeVM>>> GetAllFileType()
        {
            var data = await _fileTypeService.GetAllAsync();
            var result = _mapper.Map<IEnumerable<FileType>, IEnumerable<FileTypeVM>>(data);
            return Result.Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<Result<FileTypeVM>> GetByIdFileType(int id)
        {
            var data = await _fileTypeService.GetByIdAsync(id);
            var result = _mapper.Map<FileType, FileTypeVM>(data);
            return Result.Ok(result);
        }

        [HttpPost("[action]")]
        public async Task<Result> AddFileTypeAsync(FileType fileType)
        {
            await _fileTypeService.AddAsync(fileType);
            return Result.Ok();
        }

        [HttpPut("[action]")]
        public async Task<Result> UpdateFileType(FileType fileType)
        {
            await _fileTypeService.Update(fileType);
            return Result.Ok();
        }

        [HttpDelete("[action]")]
        public async Task<Result> DeleteFileTypeAsync(int id)
        {
            await _fileTypeService.DeleteAsync(id);
            return Result.Ok();
        }
    }
}