using Microsoft.EntityFrameworkCore;
using Octy.Application.Contracts.Persistence;
using Octy.Domain;

namespace Octy.Persistence.Repositories;

public class TopicRepository : GenericRepository<Topic>, ITopicRepository
{
    private readonly OctyDbContext _context;

    public TopicRepository(OctyDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<Topic>> GetTopicListInChapter(Guid chapterId)
    {
        return await _context.Topic
            .Where(t => t.ChapterId == chapterId)
            .ToListAsync();
    }

    public async Task<Topic> GetTopicAsync(Guid topicId)
    {
        return await _context.Topic
            .Where(t => t.Id == topicId)
            .Include(t => t.Elements)
            .ThenInclude(e => e.Attributes)
            .SingleAsync();
    }
}