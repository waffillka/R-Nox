using R_Nox.Db.Entities;
using R_Nox.Domain.Enums;

namespace R_Nox.Db.Repositories.Interfaces;

public interface ITelemetryRepository : IRepository<TelemetryEntity>
{
    Task<List<TelemetryEntity>> FilterTelemetries(ModuleType moduleType, DateTime startDate,
        DateTime endDate, List<string> fields, CancellationToken ct = default);
}