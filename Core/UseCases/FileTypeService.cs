using Core.Contracts;
using Core.Contracts.FileType;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.UseCases
{
    public class FileTypeService : IFileTypeService
    {
        private readonly IUnitOfWork _uow;
        public FileTypeService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        public async Task<IEnumerable<FileType>> GetAllAsync()
        {
            var data = await _uow.FileTypeRepository.GetAllAsync(null, x => x.OrderByDescending(x => x.Id));
            return data;
        }

        public async Task<FileType> GetByIdAsync(int id)
        {
            var data = await _uow.FileTypeRepository.GetByIdAsync(id);
            return data;
        }

        public async Task AddAsync(FileType fileType)
        {
            await _uow.FileTypeRepository.AddAsync(fileType);
            await _uow.CommitAsync();
        }

        public async Task Update(FileType fileType)
        {
            _uow.FileTypeRepository.Update(fileType);
            await _uow.CommitAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _uow.FileTypeRepository.DeleteAsync(id);
            await _uow.CommitAsync();
        }
    }
}
