using Core.Contracts.AtmCrs;
using Core.Contracts.MoneyType;
using Core.Contracts.Request;
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
        IRequestEFardaRepository RequestEFardaRepository { get; }
        IRequestMoneySupplyRepository RequestMoneySupplyRepository { get; }
        IRequestOperationDepartmentRepository RequestOperationDepartmentRepository { get; }
        IRequestTearsuryAssistantRepository RequestTearsuryAssistantRepository { get; }
        IRequestTreasuryAccountantRepository RequestTreasuryAccountantRepository { get; }
        IRequestTreasuryManagerRepository RequestTreasuryManagerRepository { get; }
    }
}
