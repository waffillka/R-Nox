using R_Nox.Services.Models.DTOs.Module;

namespace R_Nox.Services.Models.DTOs.Assembly;

public class CreateAssemblyDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<CreateModuleDto>? Modules { get; set; }
}