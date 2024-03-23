using MediatR;
using Microsoft.AspNetCore.Mvc;
using R_Nox.Services.Commands.Module;
using R_Nox.Services.Models.DTOs.Module;
using R_Nox.Services.Queries.Module;

namespace R_Nox.Controllers;

[ApiController]
[Route("api/module")]
public class ModuleController : ControllerBase
{
    private readonly IMediator _mediator;

    public ModuleController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetAssembly(Guid id, CancellationToken ct = default)
    {
        var result = await _mediator.Send(new GetModuleByIdQuery(id), ct);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAssembly(Guid id, CancellationToken ct = default)
    {
        var result = await _mediator.Send(new DeleteModuleCommand(id), ct);
        return Ok();
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateAssembly(CreateModuleDto data, CancellationToken ct = default)
    {
        var result = await _mediator.Send(new AddModuleCommand(data), ct);
        return Ok(result);
    } 
    
    [HttpPut]
    public async Task<IActionResult> UpdateAssembly(ModuleDto data, CancellationToken ct = default)
    {
        var result = await _mediator.Send(new UpdateModuleCommand(data), ct);
        return Ok(result);
    }
}
