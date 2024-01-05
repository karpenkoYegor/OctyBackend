using MediatR;
using Octy.Application.DTOs.Chapters;

namespace Octy.Application.Features.Chapters.Requests.Commands
{
    public class UpdateChapterCommand : IRequest<Unit>
    {
        public UpdateChapterDto Chapter { get; set; }
    }
}