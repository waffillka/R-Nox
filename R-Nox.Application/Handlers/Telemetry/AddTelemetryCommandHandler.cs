using R_Nox.Db.Repositories.Interfaces;
using R_Nox.Services.Commands.Telemetry;
using R_Nox.Services.Mappers;
using R_Nox.Services.Models.DTOs.Telemetry;

namespace R_Nox.Services.Handlers.Telemetry;

public class AddTelemetryCommandHandler(ITelemetryRepository telemetryRepository)
    : BaseRequestHandler<AddTelemetryCommand, TelemetryDto>
{
    private readonly ITelemetryRepository _telemetryRepository =
        telemetryRepository ?? throw new ArgumentNullException(nameof(telemetryRepository));

    public override async Task<TelemetryDto> HandleInternalAsync(AddTelemetryCommand request, CancellationToken ct)
    {
        var result = await _telemetryRepository.InsertAsync(request.Module.ToTelemetryEntity(), ct);
        return result.ToTelemetryDto();
    }
}