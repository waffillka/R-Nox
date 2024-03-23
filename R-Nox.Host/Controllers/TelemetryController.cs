using MediatR;
using Microsoft.AspNetCore.Mvc;
using R_Nox.Services.Commands.Telemetry;
using R_Nox.Services.Models.DTOs.Telemetry;
using R_Nox.Services.Queries.Telemetry;

namespace R_Nox.Controllers;

[ApiController]
[Route("api/telemetry")]
public class TelemetryController(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAssembly([FromRoute] Guid id, CancellationToken ct = default)
    {
        var result = await _mediator.Send(new GetTelemetryByIdQuery(id), ct);
        return Ok(result);
    } 
    
    [HttpGet("filter")]
    public async Task<IActionResult> GetAssembly([FromQuery] FilterTelemetryDto data, CancellationToken ct = default)
    {
        var result = await _mediator.Send(new GetFilteredTelemetryQuery(data), ct);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAssembly([FromRoute] Guid id, CancellationToken ct = default)
    {
        var result = await _mediator.Send(new DeleteTelemetryCommand(id), ct);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> CreateAssembly(UpdateTelemetryDto data, CancellationToken ct = default)
    {
        var result = await _mediator.Send(new AddTelemetryCommand(data), ct);
        return Ok(result);
    }
}