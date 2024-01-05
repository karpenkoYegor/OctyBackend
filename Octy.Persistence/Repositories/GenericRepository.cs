using Microsoft.EntityFrameworkCore;
using Octy.Application.Contracts.Persistence;

namespace Octy.Persistence.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly OctyDbContext _context;

    public GenericRepository(OctyDbContext context)
    {
        _context = context;
    }
    public async Task<T> GetAsync(Guid id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task<IReadOnlyList<T>> GetAllAsync(bool asNoTracking = true)
    {
        IQueryable<T> result = _context.Set<T>();
        if (asNoTracking)
            result = result.AsNoTracking();
        return await result.ToListAsync();
    }

    public async Task<T> AddAsync(T entity)
    {
        await _context.AddAsync(entity);
        return entity;
    }

    public async Task UpdateAsync(T entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
    }

    public async Task DeleteAsync(T entity)
    {
        _context.Set<T>().Remove(entity);
    }
    public async Task<bool> Exists(Guid id)
    {
        var entity = await GetAsync(id);
        return entity != null;
    }
}