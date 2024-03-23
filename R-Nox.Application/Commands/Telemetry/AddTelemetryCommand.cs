using MediatR;
using R_Nox.Services.Models.DTOs.Telemetry;

namespace R_Nox.Services.Commands.Telemetry;

public class AddTelemetryCommand (UpdateTelemetryDto telemetry) : IRequest<TelemetryDto>
{
    public UpdateTelemetryDto Module { get; set; } = telemetry;
}