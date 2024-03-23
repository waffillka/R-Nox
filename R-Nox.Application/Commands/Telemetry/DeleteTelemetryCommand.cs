using MediatR;

namespace R_Nox.Services.Commands.Telemetry;

public class DeleteTelemetryCommand(Guid id) : IRequest<Unit>
{
    public Guid Id { get; set; } = id;
}