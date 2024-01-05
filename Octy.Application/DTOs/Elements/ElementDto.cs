using Octy.Application.DTOs.Common;
using System.Collections.Generic;
using Octy.Application.DTOs.ElementAttributes;

namespace Octy.Application.DTOs.Elements
{
    public class ElementDto : BaseDto
    {
        public string Description { get; set; }
        public string Value { get; set; }
        public IEnumerable<ElementAttributeDto> Attributes { get; set; }
    }
}
