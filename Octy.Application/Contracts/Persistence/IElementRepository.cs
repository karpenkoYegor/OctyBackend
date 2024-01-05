using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Octy.Domain;

namespace Octy.Application.Contracts.Persistence
{
    public interface IElementRepository : IGenericRepository<Element>
    {
        public Task<List<Element>> GetElementsByTopicId(Guid topicID);
    }
}
