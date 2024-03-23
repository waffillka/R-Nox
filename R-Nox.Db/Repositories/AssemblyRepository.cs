using R_Nox.Db.Context;
using R_Nox.Db.Entities;
using R_Nox.Db.Repositories.Interfaces;

namespace R_Nox.Db.Repositories;

public class AssemblyRepository(AppDbContext dbContext) : Repository<AssemblyEntity>(dbContext), IAssemblyRepository;