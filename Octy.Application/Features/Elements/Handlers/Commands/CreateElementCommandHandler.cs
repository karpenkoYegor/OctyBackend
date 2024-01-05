using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Octy.Application.Contracts.Persistence;
using Octy.Application.Features.Elements.Requests.Commands;
using Octy.Domain;

namespace Octy.Application.Features.Elements.Handlers.Commands
{
    public class CreateElementCommandHandler : IRequestHandler<CreateElementCommand, Guid>
    {
        private readonly IElementRepository _repository;
        private readonly IMapper _mapper;

        public CreateElementCommandHandler(IElementRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        public async Task<Guid> Handle(CreateElementCommand request, CancellationToken cancellationToken)
        {
            var element = _mapper.Map<Element>(request.Element);
            element = await _repository.AddAsync(element);

            return element.Id;
        }
    }
}