using R_Nox.Db.Entities;
using R_Nox.Domain.Enums;
using R_Nox.Domain.Exceptions;

namespace R_Nox.Services.Models.DTOs.Module;

public class ModuleDto
{
    public Guid Id { get; set; }
    public Guid AssemblyId { get; set; }
    
    public ModuleType Type { get; set; }
}