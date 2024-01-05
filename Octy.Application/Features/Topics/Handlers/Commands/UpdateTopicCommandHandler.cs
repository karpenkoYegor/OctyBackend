using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Octy.Application.Contracts.Persistence;
using Octy.Application.Features.Topics.Requests.Commands;

namespace Octy.Application.Features.Topics.Handlers.Commands
{
    public class UpdateTopicCommandHandler 
        : IRequestHandler<UpdateTopicCommand, Unit>
    {
        private readonly ITopicRepository _repository;
        private readonly IMapper _mapper;

        public UpdateTopicCommandHandler(ITopicRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        public async Task<Unit> Handle(UpdateTopicCommand request, CancellationToken cancellationToken)
        {
            var topic = await _repository.GetAsync(request.Topic.Id);
            _mapper.Map(request.Topic, topic);
            await _repository.UpdateAsync(topic);
            return Unit.Value;
        }
    }
}