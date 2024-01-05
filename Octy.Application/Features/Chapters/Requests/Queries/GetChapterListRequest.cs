using MediatR;
using System.Collections.Generic;
using Octy.Application.DTOs.Chapters;

namespace Octy.Application.Features.Chapters.Requests.Queries
{
    public class GetChapterListRequest : IRequest<List<ChapterDto>>
    {
        public bool AddTopics { get; set; } = false;
    }
}
