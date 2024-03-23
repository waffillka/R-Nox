using System.Text.Json;

namespace R_Nox.Services.Models.DTOs.Telemetry;

public class CreateTelemetryDto
{
    public required JsonElement Telemetry { get; set; }
    public required Guid ModuleId { get; set; }
}