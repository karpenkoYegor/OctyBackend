using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Octy.Application.Contracts.Persistence;
using Octy.Application.DTOs.Topics;
using Octy.Application.Features.Topics.Requests.Queries;

namespace Octy.Application.Features.Topics.Handlers.Queries
{
    public class GetTopicListInChapterRequestHandler 
        : IRequestHandler<GetTopicListInChapterRequest, List<TopicListDto>>
    {
        private readonly ITopicRepository _repository;
        private readonly IMapper _mapper;

        public GetTopicListInChapterRequestHandler(ITopicRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        public async Task<List<TopicListDto>> Handle(GetTopicListInChapterRequest request, CancellationToken cancellationToken)
        {
            var chapterTopics = await _repository.GetTopicListInChapter(request.ChapterId);
            return _mapper.Map<List<TopicListDto>>(chapterTopics);
        }
    }
}