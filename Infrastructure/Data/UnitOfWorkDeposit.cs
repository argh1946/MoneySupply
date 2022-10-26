using Core.Contracts;
using Core.Contracts.Branch;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Data
{
    public class UnitOfWorkDeposit : IUnitOfWorkDeposit
    {
        protected DepositDbContext _db { get; set; }

        private IServiceProvider _serviceProvider;
        private bool _disposed;

        public UnitOfWorkDeposit(DepositDbContext db, IServiceProvider serviceProvider)
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
            throw new InvalidOperationException("This context is read-only.");
        }

        public IBranchRepository BranchRepository => _serviceProvider.GetRequiredService<IBranchRepository>();
    }
}