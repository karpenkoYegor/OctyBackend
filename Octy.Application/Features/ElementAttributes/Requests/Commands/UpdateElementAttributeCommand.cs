using MediatR;
using Octy.Application.DTOs.ElementAttributes;

namespace Octy.Application.Features.ElementAttributes.Requests.Commands
{
    public class UpdateElementAttributeCommand : IRequest<Unit>
    {
        public UpdateElementAttributeDto ElementAttribute { get; set; }
    }
}