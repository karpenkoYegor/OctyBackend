using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Octy.Application.DTOs.Chapters;
using Octy.Application.DTOs.Topics;
using Octy.Application.Features.Chapters.Requests.Commands;
using Octy.Application.Features.Chapters.Requests.Queries;
using Octy.Application.Features.Topics.Requests.Commands;
using Octy.Application.Features.Topics.Requests.Queries;

namespace Octy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TopicController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TopicController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<TopicDto>> Get(Guid id)
        {
            var topic = await _mediator.Send(new GetTopicDetailRequest() { Id = id});
            return Ok(topic);
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateTopicDto topicDto)
        {
            var command = new CreateTopicCommand() { Topic = topicDto };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateTopicDto chapterDto)
        {
            var command = new UpdateTopicCommand() { Topic = chapterDto };
            var response = await _mediator.Send(command);
            return NoContent();
        }
        [HttpDelete]
        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeleteTopicCommand() { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
