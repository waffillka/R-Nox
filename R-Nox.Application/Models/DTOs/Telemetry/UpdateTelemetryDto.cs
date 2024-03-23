using System.Text.Json;

namespace R_Nox.Services.Models.DTOs.Telemetry;

public class UpdateTelemetryDto
{
    public required JsonElement Telemetry { get; set; }
    public required Guid Id { get; set; }
}