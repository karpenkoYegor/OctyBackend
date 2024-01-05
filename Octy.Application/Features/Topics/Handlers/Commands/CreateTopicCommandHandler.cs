using AutoMapper;
using MediatR;
using Octy.Application.Features.Topics.Requests.Commands;
using Octy.Domain;
using System;
using System.Threading;
using System.Threading.Tasks;
using Octy.Application.Contracts.Persistence;

namespace Octy.Application.Features.Topics.Handlers.Commands
{
    public class CreateTopicCommandHandler 
        : IRequestHandler<CreateTopicCommand, Guid>
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public CreateTopicCommandHandler(IRepositoryWrapper repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(CreateTopicCommand request, CancellationToken cancellationToken)
        {
            var topic = _mapper.Map<Topic>(request.Topic);
            topic = await _repository.TopicRepository.AddAsync(topic);
            await _repository.SaveAsync();
            return topic.Id;
        }
    }
}
