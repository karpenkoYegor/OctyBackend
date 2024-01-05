using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Octy.Application.Contracts.Persistence;
using Octy.Application.DTOs.Chapters.Validators;
using Octy.Application.Features.Chapters.Requests.Commands;

namespace Octy.Application.Features.Chapters.Handlers.Commands
{
    public class UpdateChapterCommandHandler : IRequestHandler<UpdateChapterCommand, Unit>
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public UpdateChapterCommandHandler(IRepositoryWrapper repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateChapterCommand request, CancellationToken cancellationToken)
        {
            var topic = await _repository.ChapterRepository.GetAsync(request.Chapter.Id);

            var validator = new UpdateChapterDtoValidator();
            var validatorResult = await validator.ValidateAsync(request.Chapter);

            if (!validatorResult.IsValid)
                throw new Exception();

            _mapper.Map(request.Chapter, topic);
            await _repository.ChapterRepository.UpdateAsync(topic);
            await _repository.SaveAsync();
            return Unit.Value;
        }
    }
}