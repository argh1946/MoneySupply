
using Core.Contracts.Branch;

namespace Core.Contracts
{
    public interface IUnitOfWorkDeposit : IDisposable
    {
        Task CommitAsync();
        IBranchRepository BranchRepository { get; }
    }
}