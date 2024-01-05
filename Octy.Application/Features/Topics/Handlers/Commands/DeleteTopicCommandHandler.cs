using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Octy.Application.Contracts.Persistence;
using Octy.Application.Features.Topics.Requests.Commands;

namespace Octy.Application.Features.Topics.Handlers.Commands
{
    public class DeleteTopicCommandHandler 
        : IRequestHandler<DeleteTopicCommand, Unit>
    {
        private readonly ITopicRepository _repository;
        private readonly IMapper _mapper;

        public DeleteTopicCommandHandler(ITopicRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        public async Task<Unit> Handle(DeleteTopicCommand request, CancellationToken cancellationToken)
        {
            var topic = await _repository.GetAsync(request.Id);
            await _repository.DeleteAsync(topic);
            
            return Unit.Value;
        }
    }
}