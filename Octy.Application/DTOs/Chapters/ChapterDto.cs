using Octy.Application.DTOs.Common;
using System.Collections.Generic;
using Octy.Application.DTOs.Topics;

namespace Octy.Application.DTOs.Chapters
{
    public class ChapterDto : BaseDto
    {
        public IEnumerable<TopicDto> Topics { get; set; }
    }
}
