using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Octy.Application.Contracts.Persistence;
using Octy.Application.Features.ElementAttributes.Requests.Commands;

namespace Octy.Application.Features.ElementAttributes.Handlers.Commands
{
    public class DeleteElementAttributeCommandHandler : IRequestHandler<DeleteElementAttributeCommand, Unit>
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public DeleteElementAttributeCommandHandler(IRepositoryWrapper repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteElementAttributeCommand request, CancellationToken cancellationToken)
        {
            var elementAttribute = await _repository.ElementAttributeRepository.GetAsync(request.Id);
            await _repository.ElementAttributeRepository.DeleteAsync(elementAttribute);
            await _repository.SaveAsync();
            return Unit.Value;
        }
    }
}