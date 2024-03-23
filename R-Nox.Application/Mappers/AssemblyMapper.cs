using R_Nox.Db.Entities;
using R_Nox.Services.Models.DTOs.Assembly;

namespace R_Nox.Services.Mappers;

public static class AssemblyMapper
{
    public static AssemblyEntity ToAssemblyDto(this AssemblyDto assembly)
    {
        return new AssemblyEntity()
        {
            Id = assembly.Id,
            Name = assembly.Name,
            Description = assembly.Description,
            Modules = assembly.Modules?.Select(x => x.ToModuleEntity()).ToList()
        };
    }

    public static AssemblyEntity ToAssemblyDto(this CreateAssemblyDto updateAssembly)
    {
        var assemblyEntity = new AssemblyEntity()
        {
            Name = updateAssembly.Name,
            Description = updateAssembly.Description,
        };

        if (updateAssembly.Modules != null && updateAssembly.Modules.Count > 0)
        {
            assemblyEntity.Modules = updateAssembly.Modules.Select(x => x.ToModuleEntity(assemblyEntity)).ToList();
        }

        return assemblyEntity;
    }

    public static AssemblyDto ToAssemblyDto(this AssemblyEntity assembly)
    {
        return new AssemblyDto()
        {
            Id = assembly.Id,
            Name = assembly.Name,
            Description = assembly.Description,
            Modules = assembly.Modules?.Select(x => x.ToModuleEntity()).ToList()
        };
    }
}