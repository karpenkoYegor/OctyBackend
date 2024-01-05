using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Octy.Application.Contracts.Persistence;
using Octy.Application.Features.ElementAttributes.Requests.Commands;

namespace Octy.Application.Features.ElementAttributes.Handlers.Commands
{
    public class UpdateElementAttributeCommandHandler : IRequestHandler<UpdateElementAttributeCommand, Unit>
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public UpdateElementAttributeCommandHandler(IRepositoryWrapper repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateElementAttributeCommand request, CancellationToken cancellationToken)
        {
            var elementAttribute = await _repository.ElementAttributeRepository.GetAsync(request.ElementAttribute.Id);
            _mapper.Map(request.ElementAttribute, elementAttribute);
            await _repository.ElementAttributeRepository.UpdateAsync(elementAttribute);
            await _repository.SaveAsync();
            return Unit.Value;
        }
    }
}