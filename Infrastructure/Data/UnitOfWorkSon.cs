using Core.Contracts;
using Core.Contracts.FileAttachment;
using Core.Contracts.User;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class UnitOfWorkSon : IUnitOfWorkSon
    {
        protected SonDbContext _db { get; private set; }
        private IServiceProvider _serviceProvider;
        private bool _disposed;

        public UnitOfWorkSon(SonDbContext db, IServiceProvider serviceProvider)
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

        public IUserRepository UserRepository => _serviceProvider.GetRequiredService<IUserRepository>();

    }
}
