using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.FileType
{
    public interface IFileTypeService
    {
        Task<IEnumerable<Entities.FileType>> GetAllAsync();
        Task<Entities.FileType> GetByIdAsync(int id);
        Task AddAsync(Entities.FileType fileType);
        Task Update(Entities.FileType fileType);
        Task DeleteAsync(int id);
    }
}
