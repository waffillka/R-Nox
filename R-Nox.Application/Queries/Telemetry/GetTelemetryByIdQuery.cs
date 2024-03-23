using MediatR;
using R_Nox.Services.Models.DTOs.Telemetry;

namespace R_Nox.Services.Queries.Telemetry;

public class GetTelemetryByIdQuery(Guid id) : IRequest<TelemetryDto>
{
    public Guid Id { get; set; } = id;
}