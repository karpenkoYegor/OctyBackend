using Microsoft.EntityFrameworkCore;
using Octy.Application.Contracts.Persistence;
using Octy.Domain;

namespace Octy.Persistence.Repositories;

public class ElementAttributeRepository : GenericRepository<ElementAttribute>, IElementAttributeRepository
{
    private readonly OctyDbContext _context;

    public ElementAttributeRepository(OctyDbContext context) : base(context)
    {
        _context = context;
    }

    public Task<List<ElementAttribute>> GetElementsByElementId(Guid elementID)
    {
        return _context.ElementAttributes
            .Where(e => e.ElementId == elementID)
            .ToListAsync();
    }
}