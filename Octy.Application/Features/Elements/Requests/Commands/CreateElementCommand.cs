using System;
using MediatR;
using Octy.Application.DTOs.Elements;

namespace Octy.Application.Features.Elements.Requests.Commands
{
    public class CreateElementCommand : IRequest<Unit>, IRequest<Guid>
    {
        public CreateElementDto Element { get; set; }
    }
}