using System.Text.Json;

namespace R_Nox.Services.Models.DTOs.Telemetry;

public class TelemetryDto
{
    public Guid Id { get; set; }
    public required JsonElement Telemetry { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    public required Guid ModuleId { get; set; }
}