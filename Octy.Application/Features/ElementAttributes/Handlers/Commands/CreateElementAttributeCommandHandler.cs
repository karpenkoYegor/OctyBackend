using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Octy.Application.Contracts.Persistence;
using Octy.Application.Features.ElementAttributes.Requests.Commands;
using Octy.Domain;

namespace Octy.Application.Features.ElementAttributes.Handlers.Commands
{
    public class CreateElementAttributeCommandHandler : IRequestHandler<CreateElementAttributeCommand, Guid>
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public CreateElementAttributeCommandHandler(IRepositoryWrapper repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        public async Task<Guid> Handle(CreateElementAttributeCommand request, CancellationToken cancellationToken)
        {
            var elementAttribute = _mapper.Map<ElementAttribute>(request.ElementAttribute);
            elementAttribute = await _repository.ElementAttributeRepository.AddAsync(elementAttribute);
            await _repository.SaveAsync();
            return elementAttribute.Id;
        }
    }
}