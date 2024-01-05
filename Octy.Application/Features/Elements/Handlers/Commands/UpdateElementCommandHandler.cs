using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Octy.Application.Contracts.Persistence;
using Octy.Application.Features.Elements.Requests.Commands;

namespace Octy.Application.Features.Elements.Handlers.Commands
{
    public class UpdateElementCommandHandler : IRequestHandler<UpdateElementCommand, Unit>
    {
        private readonly IElementRepository _repository;
        private readonly IMapper _mapper;

        public UpdateElementCommandHandler(IElementRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        public async Task<Unit> Handle(UpdateElementCommand request, CancellationToken cancellationToken)
        {
            var topic = await _repository.GetAsync(request.Element.Id);
            _mapper.Map(request.Element, topic);
            await _repository.UpdateAsync(topic);
            
            return Unit.Value;
        }
    }
}