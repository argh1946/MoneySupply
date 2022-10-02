using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.FileAttachment
{
    public interface IFileAttachmentService
    {
        Task<IEnumerable<Entities.FileAttachment>> GetAllAsync();
        Task<Entities.FileAttachment> GetByIdAsync(int id);
        Task AddAsync(Entities.FileAttachment fileAttachment);       
        Task DeleteAsync(int id);
    }
}
