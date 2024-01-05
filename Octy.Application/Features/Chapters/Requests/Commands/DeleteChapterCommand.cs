using System;
using MediatR;

namespace Octy.Application.Features.Chapters.Requests.Commands
{
    public class DeleteChapterCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}