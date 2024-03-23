using R_Nox.Db.Entities;

namespace R_Nox.Services.Models.DTOs.Module;

public class ModuleDto
{
    public Guid Id { get; set; }
    public Guid AssemblyId { get; set; }
    
    public string Type { get; set; }
}