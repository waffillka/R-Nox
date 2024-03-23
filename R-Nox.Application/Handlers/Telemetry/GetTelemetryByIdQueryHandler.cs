using System.Net;
using MediatR;
using R_Nox.Db.Repositories.Interfaces;
using R_Nox.Domain.Exceptions;
using R_Nox.Services.Mappers;
using R_Nox.Services.Models.DTOs.Telemetry;
using R_Nox.Services.Queries.Telemetry;

namespace R_Nox.Services.Handlers.Telemetry;

public class GetTelemetryByIdQueryHandler(ITelemetryRepository telemetryRepository)
    : BaseRequestHandler<GetTelemetryByIdQuery, TelemetryDto>
{
    private readonly ITelemetryRepository _telemetryRepository =
        telemetryRepository ?? throw new ArgumentNullException(nameof(telemetryRepository));

    public override async Task<TelemetryDto> HandleInternalAsync(GetTelemetryByIdQuery request, CancellationToken ct)
    {
        var result = await _telemetryRepository.GetAsync(x => x.Id == request.Id, ct);

        if (result == null)
        {
            throw new HttpStatusException(HttpStatusCode.NotFound, "Cannot find telemetry.");
        }

        return result.ToTelemetryDto();
    }
}