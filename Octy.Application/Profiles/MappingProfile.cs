using AutoMapper;
using Octy.Application.DTOs.Chapters;
using Octy.Application.DTOs.ElementAttributes;
using Octy.Application.DTOs.Elements;
using Octy.Application.DTOs.Topics;
using Octy.Domain;

namespace Octy.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Chapter, ChapterDto>().ReverseMap();
            CreateMap<Chapter, CreateChapterDto>().ReverseMap();
            CreateMap<Chapter, UpdateChapterDto>().ReverseMap();
            CreateMap<Topic, TopicDto>().ReverseMap();
            CreateMap<Topic, CreateTopicDto>().ReverseMap();
            CreateMap<Topic, UpdateTopicDto>().ReverseMap();
            CreateMap<Element, ElementDto>().ReverseMap();
            CreateMap<Element, CreateElementDto>().ReverseMap();
            CreateMap<Element, UpdateElementDto>().ReverseMap();
            CreateMap<ElementAttribute, ElementAttributeDto>().ReverseMap();
            CreateMap<ElementAttribute, CreateElementAttributeDto>().ReverseMap();
            CreateMap<ElementAttribute, UpdateElementAttributeDto>().ReverseMap();
        }
    }
}
