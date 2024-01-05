using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Octy.Application.Contracts.Persistence;
using Octy.Application.DTOs.ElementAttributes;
using Octy.Application.Features.ElementAttributes.Requests.Queries;

namespace Octy.Application.Features.ElementAttributes.Handlers.Queries
{
    public class GetElementAttributesByElementIdRequestHandler : IRequestHandler<GetElementAttributesByElementIdRequest, List<ElementAttributeDto>>
    {
        private readonly IElementAttributeRepository _repository;
        private readonly IMapper _mapper;

        public GetElementAttributesByElementIdRequestHandler(IElementAttributeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ElementAttributeDto>> Handle(GetElementAttributesByElementIdRequest request, CancellationToken cancellationToken)
        {
            var elements = await _repository.GetElementsByElementId(request.Id);
            return _mapper.Map<List<ElementAttributeDto>>(elements); 
        }
    }
}