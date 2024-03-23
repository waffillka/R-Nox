using R_Nox.Services.Models.DTOs.Module;

namespace R_Nox.Services.Models.DTOs.Assembly;

public class AssemblyDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public virtual ICollection<ModuleDto>? Modules { get; set; }
}