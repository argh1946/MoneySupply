using Core.Contracts.FileAttachment;
using Core.Entities;

namespace Infrastructure.Data.Repositories
{
    public class FileAttachmentRepository : RepositoryBase<FileAttachment>, IFileAttachmentRepository
    {
        public FileAttachmentRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
