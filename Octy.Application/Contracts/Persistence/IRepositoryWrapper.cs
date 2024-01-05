using System.Threading.Tasks;

namespace Octy.Application.Contracts.Persistence
{
    public interface IRepositoryWrapper
    {
        ITopicRepository TopicRepository { get; }
        IChapterRepository ChapterRepository { get; }
        IElementRepository ElementRepository { get; }
        IElementAttributeRepository ElementAttributeRepository { get; }
        Task SaveAsync();
    }
}