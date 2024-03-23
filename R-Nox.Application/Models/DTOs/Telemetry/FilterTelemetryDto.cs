using R_Nox.Domain.Enums;

namespace R_Nox.Services.Models.DTOs.Telemetry;

public class FilterTelemetryDto
{
    public ModuleType ModuleType { get; set; }
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    public List<string> Fields { get; set; }
}