using System.Collections.Generic;
using Octy.Application.DTOs.Common;
using Octy.Application.DTOs.Topics;

namespace Octy.Application.DTOs.Chapters
{
    public class CreateChapterDto : BaseCreateDto
    {
        public IEnumerable<CreateTopicDto> Topics { get; set; }
    }
}