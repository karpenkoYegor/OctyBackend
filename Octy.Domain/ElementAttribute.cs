using System;
using Octy.Domain.Common;

namespace Octy.Domain
{
    public class ElementAttribute : BaseDomainEntity
    {
        public bool Enabled { get; set; }
        public Guid ElementId { get; set; }
        public Element Element { get; set; }
    }
}
