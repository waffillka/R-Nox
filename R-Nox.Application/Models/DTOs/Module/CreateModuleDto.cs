namespace R_Nox.Services.Models.DTOs.Module;

public class CreateModuleDto
{
    public Guid? AssemblyId { get; set; }
    public string Type { get; set; }
}