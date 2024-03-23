using R_Nox.Db.Context;
using R_Nox.Db.Entities;
using R_Nox.Db.Repositories.Interfaces;

namespace R_Nox.Db.Repositories;

public class TelemetryRepository(AppDbContext dbContext) : Repository<TelemetryEntity>(dbContext), ITelemetryRepository;