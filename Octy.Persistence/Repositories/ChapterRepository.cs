using Microsoft.EntityFrameworkCore;
using Octy.Application.Contracts.Persistence;
using Octy.Domain;

namespace Octy.Persistence.Repositories;

public class ChapterRepository : GenericRepository<Chapter>, IChapterRepository
{
    private readonly OctyDbContext _context;

    public ChapterRepository(OctyDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Chapter>> GetAllChaptersWithTopicNameAsync(bool asNoTracking = true)
    {
        IQueryable<Chapter> result = _context.Chapters.Include(c => c.Topics);
        if (asNoTracking)
            result = result.AsNoTracking();
        return await result.ToListAsync();
    }
}