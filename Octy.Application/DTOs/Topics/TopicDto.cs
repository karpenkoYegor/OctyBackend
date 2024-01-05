using Octy.Application.DTOs.Common;
using System.Collections.Generic;
using Octy.Application.DTOs.Elements;

namespace Octy.Application.DTOs.Topics
{
    public class  TopicDto : BaseDto
    {
        public IEnumerable<ElementDto> Elements { get; set; }
    }
}
