using Microsoft.EntityFrameworkCore;
using Octy.Application.Contracts.Persistence;
using Octy.Domain;

namespace Octy.Persistence.Repositories;

public class ElementRepository : GenericRepository<Element>, IElementRepository
{
    private readonly OctyDbContext _context;

    public ElementRepository(OctyDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<Element>> GetElementsByTopicId(Guid topicID)
    {
        return await _context.Elements
            .Where(e => e.TopicId == topicID)
            .ToListAsync();
    }
}