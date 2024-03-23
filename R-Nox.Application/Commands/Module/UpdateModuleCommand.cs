using MediatR;
using R_Nox.Services.Models.DTOs.Module;

namespace R_Nox.Services.Commands.Module;

public class UpdateModuleCommand(ModuleDto assembly) : IRequest<ModuleDto>
{
    public ModuleDto Module { get; set; } = assembly;
}