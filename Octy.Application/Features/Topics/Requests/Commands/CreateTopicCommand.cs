using MediatR;
using System;
using Octy.Application.DTOs.Topics;

namespace Octy.Application.Features.Topics.Requests.Commands
{
    public class CreateTopicCommand : IRequest<Guid>
    {
        public CreateTopicDto Topic { get; set; }
    }
}
