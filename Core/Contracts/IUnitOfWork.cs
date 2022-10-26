

using Core.Contracts.AtmCrs;
using Core.Contracts.FileAttachment;
using Core.Contracts.FileType;
using Core.Contracts.MoneyType;
using Core.Contracts.Request;
using Core.Contracts.RequestStatus;
using Core.Contracts.Status;

namespace Core.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        Task CommitAsync();
        IAtmCrsRepository AtmCrsRepository { get; }
        IMoneyTypeRepository MoneyTypeRepository { get; }
        IStatusRepository StatusRepository { get; }
        IRequestStatusRepository RequestStatusRepository { get; }
        IRequestEFardaRepository RequestEFardaRepository { get; }
        IRequestMoneySupplyRepository RequestMoneySupplyRepository { get; }
        IRequestOperationDepartmentRepository RequestOperationDepartmentRepository { get; }
        IRequestTearsuryAssistantRepository RequestTearsuryAssistantRepository { get; }
        IRequestTreasuryAccountantRepository RequestTreasuryAccountantRepository { get; }
        IRequestTreasuryManagerRepository RequestTreasuryManagerRepository { get; }
        IFileAttachmentRepository FileAttachmentRepository { get; }
        IFileTypeRepository FileTypeRepository { get; } 
    }
}