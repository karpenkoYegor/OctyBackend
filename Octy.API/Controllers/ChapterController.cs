using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Octy.Application.DTOs.Chapters;
using Octy.Application.Features.Chapters.Requests.Commands;
using Octy.Application.Features.Chapters.Requests.Queries;

namespace Octy.API.Controllers;
[ApiController]
[Route("api/[controller]")]
[Authorize]
public class ChapterController : ControllerBase
{
    private readonly IMediator _mediator;

    public ChapterController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ChapterDto>>> Get()
    {
        var chapters = await _mediator.Send(new GetChapterListRequest() { AddTopics = false });
        return Ok(chapters);
    }
    [HttpPost]
    public async Task<ActionResult> Post([FromBody] CreateChapterDto chapterDto)
    {
        var command = new CreateChapterCommand() { Chapter = chapterDto };
        var response = await _mediator.Send(command);
        return Ok(response);
    }

    [HttpPut]
    public async Task<ActionResult> Put([FromBody] UpdateChapterDto chapterDto)
    {
        var command = new UpdateChapterCommand() { Chapter = chapterDto };
        var response = await _mediator.Send(command);
        return NoContent();
    }
    [HttpDelete]
    public async Task<ActionResult> Delete(Guid id)
    {
        var command = new DeleteChapterCommand() { Id = id };
        await _mediator.Send(command);
        return NoContent();
    }
}