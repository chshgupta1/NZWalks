using NZWalks.ApI.Models.Domain;

namespace NZWalks.ApI.Repositories
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetAllAsync();
    }
}