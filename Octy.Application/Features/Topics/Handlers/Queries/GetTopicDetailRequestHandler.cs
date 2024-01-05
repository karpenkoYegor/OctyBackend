using AutoMapper;
using MediatR;
using Octy.Application.Features.Topics.Requests.Queries;
using System.Threading;
using System.Threading.Tasks;
using Octy.Application.Contracts.Persistence;
using Octy.Application.DTOs.Topics;

namespace Octy.Application.Features.Topics.Handlers.Queries
{
    internal class GetTopicDetailRequestHandler 
        : IRequestHandler<GetTopicDetailRequest, TopicDto>
    {
        private readonly ITopicRepository _repository;
        private readonly IMapper _mapper;

        public GetTopicDetailRequestHandler(ITopicRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<TopicDto> Handle(GetTopicDetailRequest request, CancellationToken cancellationToken)
        {
            var topic = await _repository.GetTopicAsync(request.Id);
            return _mapper.Map<TopicDto>(topic); 
        }
    }
}
