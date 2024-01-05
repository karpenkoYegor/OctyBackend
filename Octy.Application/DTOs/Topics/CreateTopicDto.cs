using System;
using System.Collections.Generic;
using Octy.Application.DTOs.Common;
using Octy.Application.DTOs.Elements;

namespace Octy.Application.DTOs.Topics
{
    public class CreateTopicDto : BaseCreateDto
    {
        public Guid ChapterId { get; set; }
        public IEnumerable<CreateElementDto> Elements { get; set; }
    }
}