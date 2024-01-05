using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Octy.Application.Contracts.Persistence;
using Octy.Application.DTOs.Elements;
using Octy.Application.Features.Elements.Requests.Queries;

namespace Octy.Application.Features.Elements.Handlers.Queries
{
    public class GetElementByTopicIdRequestHandler : IRequestHandler<GetElementByTopicIdRequest, List<ElementDto>>
    {
        private readonly IElementRepository _repository;
        private readonly IMapper _mapper;

        public GetElementByTopicIdRequestHandler(IElementRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ElementDto>> Handle(GetElementByTopicIdRequest request, CancellationToken cancellationToken)
        {
            var elements = await _repository.GetElementsByTopicId(request.Id);
            return _mapper.Map<List<ElementDto>>(elements); 
        }
    }
}