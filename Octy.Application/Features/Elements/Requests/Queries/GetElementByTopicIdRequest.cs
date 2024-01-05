using System;
using System.Collections.Generic;
using MediatR;
using Octy.Application.DTOs.Elements;

namespace Octy.Application.Features.Elements.Requests.Queries
{
    public class GetElementByTopicIdRequest : IRequest<List<ElementDto>>
    {
        public Guid Id { get; set; }
    }
}