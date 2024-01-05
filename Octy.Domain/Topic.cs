using System;
using Octy.Domain.Common;
using System.Collections.Generic;

namespace Octy.Domain
{
    public class Topic : BaseDomainEntity
    {
        public Guid ChapterId { get; set; }
        public Chapter Chapter { get; set; }
        public Tasks Tasks { get; set; }
        public IEnumerable<Element> Elements { get; set; }
    }
}
