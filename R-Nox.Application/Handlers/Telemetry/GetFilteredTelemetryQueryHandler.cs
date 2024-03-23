using R_Nox.Db.Repositories.Interfaces;
using R_Nox.Services.Mappers;
using R_Nox.Services.Models.DTOs.Telemetry;
using R_Nox.Services.Queries.Telemetry;

namespace R_Nox.Services.Handlers.Telemetry;

public class GetFilteredTelemetryQueryHandler(ITelemetryRepository telemetryRepository)
    : BaseRequestHandler<GetFilteredTelemetryQuery, List<TelemetryDto>>
{
    private readonly ITelemetryRepository _telemetryRepository =
        telemetryRepository ?? throw new ArgumentNullException(nameof(telemetryRepository));

    public override async Task<List<TelemetryDto>> HandleInternalAsync(GetFilteredTelemetryQuery request,
        CancellationToken ct)
    {
        var result = await _telemetryRepository.FilterTelemetries(request.Data.ModuleType, request.Data.From,
            request.Data.To, request.Data.Fields, ct);
        return result.Select(x => x.ToTelemetryDto()).ToList();
    }
}