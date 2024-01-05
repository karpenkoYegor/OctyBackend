using MediatR;
using System;
using Octy.Application.DTOs.Topics;

namespace Octy.Application.Features.Topics.Requests.Queries
{
    public class GetTopicDetailRequest : IRequest<TopicDto>
    {
        public Guid Id { get; set; }
    }
}
