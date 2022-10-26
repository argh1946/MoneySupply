using Core.Contracts;
using Core.Contracts.Branch;
using Core.Entities;

namespace Core.UseCases
{
    public class BranchService : IBranchService
    {
        private readonly IUnitOfWorkDeposit _uow;
        public BranchService(IUnitOfWorkDeposit unitOfWork)
        {
            _uow = unitOfWork;
        }

        public async Task<IEnumerable<Branch>> GetAll()
        {
            var data = await _uow.BranchRepository.GetAll();
            return data;
        }

        public async Task<IEnumerable<Branch>> GetAllAsync()
        {
            var data = await _uow.BranchRepository.GetAllAsync();
            return data;
        }

        public async Task<Branch> GetByIdAsync(int id)
        {
            var data = await _uow.BranchRepository.GetByIdAsync(id);
            return data;
        }

        
    }
}