using System;
using MediatR;

namespace Octy.Application.Features.Elements.Requests.Commands
{
    public class DeleteElementCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}