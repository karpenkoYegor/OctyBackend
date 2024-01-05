using System;
using System.Collections.Generic;
using MediatR;
using Octy.Application.DTOs.Topics;

namespace Octy.Application.Features.Topics.Requests.Queries
{
    public class GetTopicListInChapterRequest : IRequest<List<TopicListDto>>
    {
        public Guid ChapterId { get; set; }
    }
}