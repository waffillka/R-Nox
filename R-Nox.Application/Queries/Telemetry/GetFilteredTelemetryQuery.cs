using MediatR;
using R_Nox.Services.Models.DTOs.Telemetry;

namespace R_Nox.Services.Queries.Telemetry;

public class GetFilteredTelemetryQuery(FilterTelemetryDto data) : IRequest<List<TelemetryDto>>
{
    public FilterTelemetryDto Data { get; set; } = data;
}