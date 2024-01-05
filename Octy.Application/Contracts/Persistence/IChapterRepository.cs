using System.Collections.Generic;
using System.Threading.Tasks;
using Octy.Domain;

namespace Octy.Application.Contracts.Persistence
{
    public interface IChapterRepository : IGenericRepository<Chapter>
    {
        public Task<IEnumerable<Chapter>> GetAllChaptersWithTopicNameAsync(bool asNoTracking = true);
    }
}
