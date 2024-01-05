using System;
using AutoMapper;
using MediatR;
using Octy.Application.Features.Chapters.Requests.Queries;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Octy.Application.Contracts.Persistence;
using Octy.Application.DTOs.Chapters;
using Octy.Application.DTOs.ElementAttributes;
using Octy.Application.DTOs.Elements;
using Octy.Application.DTOs.Topics;
using Octy.Domain;

namespace Octy.Application.Features.Chapters.Handlers.Queries
{
    public class GetChapterListRequestHandler : IRequestHandler<GetChapterListRequest, List<ChapterDto>>
    {
        private readonly IChapterRepository _repository;
        private readonly IMapper _mapper;

        public GetChapterListRequestHandler(IChapterRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ChapterDto>> Handle(GetChapterListRequest request, CancellationToken cancellationToken)
        {
            var chapters = await _repository.GetAllChaptersWithTopicNameAsync();
            return _mapper.Map<List<ChapterDto>>(chapters);
        }
    }
}
