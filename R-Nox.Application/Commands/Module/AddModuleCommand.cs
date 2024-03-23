using MediatR;
using R_Nox.Services.Models.DTOs.Module;

namespace R_Nox.Services.Commands.Module;

public class AddModuleCommand(CreateModuleDto assembly) : IRequest<ModuleDto>
{
    public CreateModuleDto Module { get; set; } = assembly;
}