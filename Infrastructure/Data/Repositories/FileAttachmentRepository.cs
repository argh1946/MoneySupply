using Core.Contracts.AtmCrs;
using Core.Contracts.FileAttachment;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class FileAttachmentRepository : RepositoryBase<FileAttachment>, IFileAttachmentRepository
    {
        public FileAttachmentRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
