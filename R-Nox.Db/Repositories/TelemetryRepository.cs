using System.Runtime.CompilerServices;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using R_Nox.Db.Context;
using R_Nox.Db.Entities;
using R_Nox.Db.Repositories.Interfaces;
using R_Nox.Domain.Enums;

namespace R_Nox.Db.Repositories;

public class TelemetryRepository(AppDbContext dbContext) : Repository<TelemetryEntity>(dbContext), ITelemetryRepository
{
    public async Task<List<TelemetryEntity>> FilterTelemetries(ModuleType moduleType, DateTime startDate,
        DateTime endDate, List<string> fields, CancellationToken ct = default)
    {
        var result = DbContext.Telemetries
            .Where(t => t.Timestamp >= startDate && t.Timestamp <= endDate)
            .Include(m => m.Module)
            .Where(x => x.Module.Type == moduleType)
            .Select(t => new TelemetryEntity
            {
                Id = t.Id,
                Timestamp = t.Timestamp,
                ModuleId = t.ModuleId,
                Telemetry = FilterTelemetries1212(t.Telemetry, fields)
            });

        return await result.ToListAsync<TelemetryEntity>(ct);
    }

    private static JsonElement FilterTelemetries1212(JsonElement Telemetry, List<string> fields)
    {
        JObject originalObject = JObject.Parse(Telemetry.GetRawText());
        JObject newObject = new JObject();

        foreach (string field in fields)
        {
            if (originalObject.TryGetValue(field, StringComparison.OrdinalIgnoreCase, out JToken value))
            {
                newObject[field] = value;
            }
        }
        
        using (JsonDocument jsonDocument = JsonDocument.Parse(newObject.ToString()))
        {
            return jsonDocument.RootElement.Clone();
        }
    }
}