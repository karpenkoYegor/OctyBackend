using MediatR;
using Octy.Application.DTOs.Elements;

namespace Octy.Application.Features.Elements.Requests.Commands
{
    public class UpdateElementCommand : IRequest<Unit>
    {
        public UpdateElementDto Element { get; set; }
    }
}