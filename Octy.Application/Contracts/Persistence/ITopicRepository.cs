using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Octy.Domain;

namespace Octy.Application.Contracts.Persistence
{
    public interface ITopicRepository : IGenericRepository<Topic>
    {
        public Task<List<Topic>> GetTopicListInChapter(Guid chapterId);
        public Task<Topic> GetTopicAsync(Guid topicId);
    }
}
