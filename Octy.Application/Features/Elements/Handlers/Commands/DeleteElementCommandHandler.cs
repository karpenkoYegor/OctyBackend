using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Octy.Application.Contracts.Persistence;
using Octy.Application.Features.Elements.Requests.Commands;

namespace Octy.Application.Features.Elements.Handlers.Commands
{
    public class DeleteElementCommandHandler : IRequestHandler<DeleteElementCommand, Unit>
    {
        private readonly IElementRepository _repository;
        private readonly IMapper _mapper;

        public DeleteElementCommandHandler(IElementRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        public async Task<Unit> Handle(DeleteElementCommand request, CancellationToken cancellationToken)
        {
            var element = await _repository.GetAsync(request.Id);
            await _repository.DeleteAsync(element);
            
            return Unit.Value;
        }
    }
}