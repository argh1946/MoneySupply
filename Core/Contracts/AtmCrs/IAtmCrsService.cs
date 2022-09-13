
namespace Core.Contracts.AtmCrs
{
    public interface IAtmCrsService
    {
        Task<IEnumerable<Entities.AtmCrs>> GetAllAsync();
    }
}
