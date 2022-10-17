using Core.Contracts;
using Core.Contracts.User;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.UseCases
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWorkSon _uow;
        public UserService(IUnitOfWorkSon uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            var data = await _uow.UserRepository.GetAllAsync(null, x => x.OrderByDescending(x => x.Id));
            return data;

        }
    }
}
