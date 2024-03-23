using R_Nox.Db.Repositories.Interfaces;
using R_Nox.Services.Commands.Module;
using R_Nox.Services.Mappers;
using R_Nox.Services.Models.DTOs.Module;

namespace R_Nox.Services.Handlers.Module;

public class AddModuleCommandHandler : BaseRequestHandler<AddModuleCommand, ModuleDto>
{
    private readonly IModuleRepository _moduleRepository;

    public AddModuleCommandHandler(IModuleRepository moduleRepository)
    {
        _moduleRepository = moduleRepository ?? throw new ArgumentNullException(nameof(moduleRepository));
    }

    public override async Task<ModuleDto> HandleInternalAsync(AddModuleCommand request, CancellationToken ct)
    {
        var result = await _moduleRepository.UpdateAsync(request.Module.ToModuleEntity(), ct);
        return result.ToModuleEntity();
    }
}