using Core.Contracts;
using Core.Contracts.FileAttachment;
using Core.DTOs;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.UseCases
{
    public class FileAttachmentService : IFileAttachmentService
    {
        private readonly IUnitOfWork _uow;
        public FileAttachmentService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task AddAsync(FileAttachment fileAttachment)
        {
            await _uow.FileAttachmentRepository.AddAsync(fileAttachment);
            await _uow.CommitAsync();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<FileAttachment>> GetAllAsync()
        {
            var data = await _uow.FileAttachmentRepository.GetAllAsync(null, x => x.OrderByDescending(x => x.Id));
            return data;
        }

        public Task<FileAttachment> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
