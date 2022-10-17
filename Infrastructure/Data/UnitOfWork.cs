using Core.Contracts;
using Core.Contracts.AtmCrs;
using Core.Contracts.FileAttachment;
using Core.Contracts.MoneyType;
using Core.Contracts.Request;
using Core.Contracts.RequestStatus;
using Core.Contracts.Status;
using Core.Contracts.User;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        protected ApplicationDbContext _db { get; private set; }
        private IServiceProvider _serviceProvider;
        private bool _disposed;

        public UnitOfWork(ApplicationDbContext db, IServiceProvider serviceProvider)
        {
            _db = db;
            _serviceProvider = serviceProvider;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_db != null)
                    {
                        _db.Dispose();
                        _db = null;
                    }                   
                }
                _disposed = true;
            }

        }

        public async Task CommitAsync()
        {
            await _db.SaveChangesAsync();
        }

        
        public IAtmCrsRepository AtmCrsRepository => _serviceProvider.GetRequiredService<IAtmCrsRepository>();       
        public IMoneyTypeRepository MoneyTypeRepository => _serviceProvider.GetRequiredService<IMoneyTypeRepository>();       
        public IStatusRepository StatusRepository => _serviceProvider.GetRequiredService<IStatusRepository>();       
        public IRequestStatusRepository RequestStatusRepository => _serviceProvider.GetRequiredService<IRequestStatusRepository>();       
        public IRequestMoneySupplyRepository RequestMoneySupplyRepository => _serviceProvider.GetRequiredService<IRequestMoneySupplyRepository>();       
        public IRequestOperationDepartmentRepository RequestOperationDepartmentRepository => _serviceProvider.GetRequiredService<IRequestOperationDepartmentRepository>();       
        public IRequestTearsuryAssistantRepository RequestTearsuryAssistantRepository => _serviceProvider.GetRequiredService<IRequestTearsuryAssistantRepository>();       
        public IRequestTreasuryAccountantRepository RequestTreasuryAccountantRepository => _serviceProvider.GetRequiredService<IRequestTreasuryAccountantRepository>();       
        public IRequestTreasuryManagerRepository RequestTreasuryManagerRepository => _serviceProvider.GetRequiredService<IRequestTreasuryManagerRepository>();       
        public IRequestEFardaRepository RequestEFardaRepository => _serviceProvider.GetRequiredService<IRequestEFardaRepository>();       
        public IFileAttachmentRepository FileAttachmentRepository => _serviceProvider.GetRequiredService<IFileAttachmentRepository>();


    }
}