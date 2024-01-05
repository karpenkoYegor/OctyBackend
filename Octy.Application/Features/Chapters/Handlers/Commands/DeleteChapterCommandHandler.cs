using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Octy.Application.Contracts.Persistence;
using Octy.Application.Features.Chapters.Requests.Commands;

namespace Octy.Application.Features.Chapters.Handlers.Commands
{
    public class DeleteChapterCommandHandler : IRequestHandler<DeleteChapterCommand, Unit>
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public DeleteChapterCommandHandler(IRepositoryWrapper repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<Unit> Handle(DeleteChapterCommand request, CancellationToken cancellationToken)
        {
            var topic = await _repository.ChapterRepository.GetAsync(request.Id);
            await _repository.ChapterRepository.DeleteAsync(topic);
            await _repository.SaveAsync();
            return Unit.Value;
        }
    }
}