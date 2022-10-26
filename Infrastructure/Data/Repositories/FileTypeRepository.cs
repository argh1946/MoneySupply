using Core.Entities;
using Core.Contracts.FileType;

namespace Infrastructure.Data.Repositories
{
    public class FileTypeRepository : RepositoryBase<FileType>, IFileTypeRepository
    {
        public FileTypeRepository(ApplicationDbContext db) : base(db)
        { 
        }
    }
}
