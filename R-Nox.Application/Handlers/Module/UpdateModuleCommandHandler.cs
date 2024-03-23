using R_Nox.Db.Repositories.Interfaces;
using R_Nox.Services.Commands.Module;
using R_Nox.Services.Mappers;
using R_Nox.Services.Models.DTOs.Module;

namespace R_Nox.Services.Handlers.Module;

public class UpdateModuleCommandHandler(IModuleRepository moduleRepository)
    : BaseRequestHandler<UpdateModuleCommand, ModuleDto>
{
    private readonly IModuleRepository _moduleRepository = moduleRepository ?? throw new ArgumentNullException(nameof(moduleRepository));

    public override async Task<ModuleDto> HandleInternalAsync(UpdateModuleCommand request,
        CancellationToken ct = default)
    {
        var result = await _moduleRepository.UpdateAsync(request.Module.ToModuleEntity(), ct);
        return result.ToModuleEntity();
    }
}