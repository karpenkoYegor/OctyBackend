using System;
using MediatR;
using Octy.Application.DTOs.ElementAttributes;

namespace Octy.Application.Features.ElementAttributes.Requests.Commands
{
    public class CreateElementAttributeCommand : IRequest<Guid>
    {
        public ElementAttributeDto ElementAttribute { get; set; }
    }
}