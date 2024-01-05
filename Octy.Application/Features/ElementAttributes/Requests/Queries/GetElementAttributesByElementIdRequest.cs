using System;
using System.Collections.Generic;
using MediatR;
using Octy.Application.DTOs.ElementAttributes;

namespace Octy.Application.Features.ElementAttributes.Requests.Queries
{
    public class GetElementAttributesByElementIdRequest : IRequest<List<ElementAttributeDto>>
    {
        public Guid Id { get; set; }
    }
}