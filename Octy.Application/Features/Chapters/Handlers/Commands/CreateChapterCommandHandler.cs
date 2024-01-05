using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Octy.Application.Contracts.Persistence;
using Octy.Application.DTOs.Chapters.Validators;
using Octy.Application.Features.Chapters.Requests.Commands;
using Octy.Domain;

namespace Octy.Application.Features.Chapters.Handlers.Commands
{
    public class CreateChapterCommandHandler : IRequestHandler<CreateChapterCommand, Guid>
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public CreateChapterCommandHandler(IRepositoryWrapper repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        public async Task<Guid> Handle(CreateChapterCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateChapterDtoValidator();
            var validatorResult = await validator.ValidateAsync(request.Chapter);

            if (!validatorResult.IsValid)
                throw new Exception();
            
            var chapter = _mapper.Map<Chapter>(request.Chapter);
            var result = await _repository.ChapterRepository.AddAsync(chapter);
            await _repository.SaveAsync();
            return result.Id;
        }
    }
}