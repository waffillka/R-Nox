using R_Nox.Db.Entities;
using R_Nox.Services.Models.DTOs.Module;

namespace R_Nox.Services.Mappers;

public static class ModuleMapper
{
    public static ModuleEntity ToModuleEntity(this ModuleDto module)
    {
        return new ModuleEntity()
        {
            AssemblyId = module.AssemblyId,
            Id = module.Id,
            Type = module.Type
        };
    }

    public static ModuleDto ToModuleEntity(this ModuleEntity module)
    {
        return new ModuleDto()
        {
            AssemblyId = module.AssemblyId,
            Id = module.Id,
            Type = module.Type
        };
    }

    public static ModuleEntity ToModuleEntity(this CreateModuleDto module, AssemblyEntity assembly)
    {
        return new ModuleEntity()
        {
            Assembly = assembly,
            Type = module.Type
        };
    }

    public static ModuleEntity ToModuleEntity(this CreateModuleDto module)
    {
        return new ModuleEntity()
        {
            AssemblyId = (Guid)module.AssemblyId!,
            Type = module.Type
        };
    }
}