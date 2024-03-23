using R_Nox.Db.Repositories.Interfaces;
using R_Nox.Services.Commands.Assembly;
using R_Nox.Services.Mappers;
using R_Nox.Services.Models.DTOs.Assembly;

namespace R_Nox.Services.Handlers.Assembly;

public class UpdateAssemblyCommandHandler(IAssemblyRepository assemblyRepository)
    : BaseRequestHandler<UpdateAssemblyCommand, AssemblyDto>
{
    private readonly IAssemblyRepository _assemblyRepository = assemblyRepository ?? throw new ArgumentNullException(nameof(assemblyRepository));

    public override async Task<AssemblyDto> HandleInternalAsync(UpdateAssemblyCommand request, CancellationToken ct)
    {
        var result = await _assemblyRepository.UpdateAsync(request.Assembly.ToAssemblyDto(), ct);
        return result.ToAssemblyDto();
    }
}