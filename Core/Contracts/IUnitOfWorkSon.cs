using Core.Contracts.FileAttachment;
using Core.Contracts.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts
{
    public interface IUnitOfWorkSon : IDisposable
    {
        Task CommitAsync();
        IUserRepository UserRepository { get; }

    }
}
