using System;
using MediatR;

namespace Octy.Application.Features.ElementAttributes.Requests.Commands
{
    public class DeleteElementAttributeCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}