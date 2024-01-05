using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Octy.Domain;

namespace Octy.Application.Contracts.Persistence
{
    public interface IElementAttributeRepository : IGenericRepository<ElementAttribute>
    {
        public Task<List<ElementAttribute>> GetElementsByElementId(Guid elementID);
    }
}
