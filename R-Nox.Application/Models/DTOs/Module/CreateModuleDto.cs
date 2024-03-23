using R_Nox.Domain.Enums;
using R_Nox.Domain.Exceptions;

namespace R_Nox.Services.Models.DTOs.Module;

public class CreateModuleDto
{
    public Guid? AssemblyId { get; set; }
    public ModuleType Type { get; set; }
}