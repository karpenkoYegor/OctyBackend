using System;
using MediatR;

namespace Octy.Application.Features.Topics.Requests.Commands
{
    public class DeleteTopicCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}