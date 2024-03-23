using R_Nox.Db.Repositories.Interfaces;
using R_Nox.Services.Mappers;
using R_Nox.Services.Models.DTOs.Module;
using R_Nox.Services.Queries.Module;

namespace R_Nox.Services.Handlers.Module;

public class GetModuleCommandHandler: BaseRequestHandler<GetModuleByIdQuery, ModuleDto>
{
    private readonly IModuleRepository _moduleRepository;

    public GetModuleCommandHandler(IModuleRepository moduleRepository)
    {
        _moduleRepository = moduleRepository ?? throw new ArgumentNullException(nameof(moduleRepository));
    }

    public override async Task<ModuleDto> HandleInternalAsync(GetModuleByIdQuery request, CancellationToken ct = default)
    {
        var result = await _moduleRepository.GetAsync(x => x.Id == request.Id, ct);
        
        if (result == null)
        {
            //throw new NotFoundException();
        }
        
        return result.ToModuleEntity();
    }
}