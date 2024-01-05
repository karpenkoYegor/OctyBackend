using System;
using MediatR;
using Octy.Application.DTOs.Chapters;

namespace Octy.Application.Features.Chapters.Requests.Commands
{
    public class CreateChapterCommand : IRequest<Guid>
    {
        public CreateChapterDto Chapter { get; set; }
    }
}