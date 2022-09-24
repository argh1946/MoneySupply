using Core.Contracts.AtmCrs;
using Core.Contracts.MoneyType;
using Core.Contracts.Status;
using System;
using System.Threading.Tasks;

namespace Core.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        Task CommitAsync();
        IAtmCrsRepository AtmCrsRepository { get; }
        IMoneyTypeRepository MoneyTypeRepository { get; }
        IStatusRepository StatusRepository { get; }
    }
}
