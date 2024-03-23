using MediatR;
using Microsoft.AspNetCore.Mvc;
using R_Nox.Services.Commands.Assembly;
using R_Nox.Services.Models.DTOs.Assembly;
using R_Nox.Services.Queries.Assembly;

namespace R_Nox.Controllers;

[ApiController]
[Route("api/assembly")]
public class AssemblyController : ControllerBase
{
    private readonly IMediator _mediator;

    public AssemblyController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAssembly(Guid id, CancellationToken ct = default)
    {
        var result = await _mediator.Send(new GetAssemblyByIdQuery(id), ct);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAssembly(Guid id, CancellationToken ct = default)
    {
        var result = await _mediator.Send(new DeleteAssemblyCommand(id), ct);
        return Ok();
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateAssembly(CreateAssemblyDto data, CancellationToken ct = default)
    {
        var result = await _mediator.Send(new AddAssemblyCommand(data), ct);
        return Ok(result);
    } 
    
    [HttpPut]
    public async Task<IActionResult> UpdateAssembly(AssemblyDto data, CancellationToken ct = default)
    {
        var result = await _mediator.Send(new UpdateAssemblyCommand(data), ct);
        return Ok(result);
    }
}