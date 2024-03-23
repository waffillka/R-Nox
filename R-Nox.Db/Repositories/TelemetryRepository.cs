using R_Nox.Db.Context;
using R_Nox.Db.Entities;
using R_Nox.Db.Repositories.Interfaces;

namespace R_Nox.Db.Repositories;

public class TelemetryRepository: Repository<TelemetryEntity>, ITelemetryRepository
{
    public TelemetryRepository(AppDbContext dbContext)
        : base(dbContext)
    {
    }
}