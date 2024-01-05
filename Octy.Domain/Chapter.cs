using Octy.Domain.Common;
using System.Collections.Generic;

namespace Octy.Domain
{
    public class Chapter : BaseDomainEntity
    {
        public IEnumerable<Topic> Topics { get; set; }
    }
}
