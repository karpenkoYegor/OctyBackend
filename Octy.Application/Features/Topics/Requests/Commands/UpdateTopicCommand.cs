using MediatR;
using Octy.Application.DTOs.Topics;

namespace Octy.Application.Features.Topics.Requests.Commands
{
    public class UpdateTopicCommand : IRequest<Unit>
    {
        public UpdateTopicDto Topic { get; set; }
    }
}