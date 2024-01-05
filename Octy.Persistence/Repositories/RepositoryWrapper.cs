using Microsoft.EntityFrameworkCore;
using Octy.Application.Contracts.Persistence;

namespace Octy.Persistence.Repositories;

public class RepositoryWrapper : IRepositoryWrapper
{
    private readonly OctyDbContext _context;
    private ITopicRepository _topicRepository;
    private IChapterRepository _chapterRepository;
    private IElementRepository _elementRepository;
    private IElementAttributeRepository _elementAttributeRepository;

    public RepositoryWrapper(OctyDbContext context)
    {
        _context = context;
    }

    public ITopicRepository TopicRepository
    {
        get
        {
            if (_topicRepository == null)
                _topicRepository = new TopicRepository(_context);
            return _topicRepository;
        }
    }

    public IChapterRepository ChapterRepository
    {
        get
        {
            if (_chapterRepository == null)
                _chapterRepository = new ChapterRepository(_context);
            return _chapterRepository;
        }
    }

    public IElementRepository ElementRepository
    {
        get
        {
            if( _elementRepository == null)
                _elementRepository = new ElementRepository(_context);
            return _elementRepository;
        }
    }

    public IElementAttributeRepository ElementAttributeRepository
    {
        get
        {
            if (_elementAttributeRepository == null)
                _elementAttributeRepository = new ElementAttributeRepository(_context);
            return _elementAttributeRepository;
        }
    }

    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }
}