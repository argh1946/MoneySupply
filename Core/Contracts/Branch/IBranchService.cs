namespace Core.Contracts.Branch
{
    public interface IBranchService 
    {
        Task<IEnumerable<Entities.Branch>> GetAllAsync();
        Task<Entities.Branch> GetByIdAsync(int id);
        Task<IEnumerable<Entities.Branch>> GetAll();
    }
}