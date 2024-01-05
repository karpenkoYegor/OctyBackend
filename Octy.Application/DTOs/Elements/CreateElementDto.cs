using System.Collections.Generic;
using Octy.Application.DTOs.Common;
using Octy.Application.DTOs.ElementAttributes;

namespace Octy.Application.DTOs.Elements
{
    public class CreateElementDto : BaseCreateDto
    {
        public string Description { get; set; }
        public string Value { get; set; }
        public IEnumerable<CreateElementAttributeDto> ElementAttributes { get; set; }
    }
}