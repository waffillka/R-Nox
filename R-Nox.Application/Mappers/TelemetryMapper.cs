using R_Nox.Db.Entities;
using R_Nox.Services.Models.DTOs.Telemetry;

namespace R_Nox.Services.Mappers;

public static class TelemetryMapper
{
    public static TelemetryDto ToTelemetryDto(this TelemetryEntity data)
    {
        return new TelemetryDto()
        {
            Id = data.Id,
            Telemetry = data.Telemetry,
            Timestamp = data.Timestamp,
            ModuleId = data.ModuleId
        };
    }

    public static TelemetryEntity ToTelemetryEntity(this TelemetryDto data)
    {
        return new TelemetryEntity()
        {
            Id = data.Id,
            Telemetry = data.Telemetry,
            Timestamp = data.Timestamp,
            ModuleId = data.ModuleId
        };
    }

    public static TelemetryEntity ToTelemetryEntity(this CreateTelemetryDto data)
    {
        return new TelemetryEntity()
        {
            Telemetry = data.Telemetry,
            ModuleId = data.ModuleId
        };
    }

    public static TelemetryEntity ToTelemetryEntity(this UpdateTelemetryDto data)
    {
        return new TelemetryEntity()
        {
            ModuleId = data.Id,
            Telemetry = data.Telemetry
        };
    }
}