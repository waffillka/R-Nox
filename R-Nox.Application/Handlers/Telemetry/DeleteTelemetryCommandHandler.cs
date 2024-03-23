using MediatR;
using R_Nox.Db.Repositories.Interfaces;
using R_Nox.Services.Commands.Telemetry;

namespace R_Nox.Services.Handlers.Telemetry;

public class DeleteTelemetryCommandHandler(ITelemetryRepository telemetryRepository)
    : BaseRequestHandler<DeleteTelemetryCommand, Unit>
{
    private readonly ITelemetryRepository _telemetryRepository =
        telemetryRepository ?? throw new ArgumentNullException(nameof(telemetryRepository));

    public override async Task<Unit> HandleInternalAsync(DeleteTelemetryCommand request, CancellationToken ct)
    {
        await _telemetryRepository.Delete(x => x.Id == request.Id, ct);
        return Unit.Value;
    }
}