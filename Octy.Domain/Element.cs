using System;
using Octy.Domain.Common;
using System.Collections.Generic;

namespace Octy.Domain
{
    public class Element : BaseDomainEntity
    {
        public string Description { get; set; }
        public string Value { get; set; }
        public Guid TopicId { get; set; }
        public Topic Topic { get; set; }
        public IEnumerable<ElementAttribute> Attributes { get; set; }
    }
}
