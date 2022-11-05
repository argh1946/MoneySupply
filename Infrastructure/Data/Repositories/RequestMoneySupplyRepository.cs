using Core.Contracts.Request;
using Core.Entities;

namespace Infrastructure.Data.Repositories
{
    public class RequestMoneySupplyRepository : RepositoryBase<Request>, IRequestMoneySupplyRepository
    {
        public RequestMoneySupplyRepository(ApplicationDbContext db) : base(db)
        {
        }

        public async Task AddWithFile(Request request)
        {
            var req = new Request
            {
                RequestType = request.RequestType,
                AtmCrsId = request.AtmCrsId,
                FileAttachments = new List<FileAttachment>()
            };
            req.FileAttachments.Add(new FileAttachment { Title = "jsj",FileTypeId = 1 });

            await _db.Request.AddAsync(req);
        }
    }
}

