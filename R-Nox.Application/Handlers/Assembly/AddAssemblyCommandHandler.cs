using R_Nox.Db.Repositories.Interfaces;
using R_Nox.Services.Commands.Assembly;
using R_Nox.Services.Mappers;
using R_Nox.Services.Models.DTOs.Assembly;

namespace R_Nox.Services.Handlers.Assembly;

public class AddAssemblyCommandHandler(IAssemblyRepository assemblyRepository)
    : BaseRequestHandler<AddAssemblyCommand, AssemblyDto>
{
    private readonly IAssemblyRepository _assemblyRepository = assemblyRepository ?? throw new ArgumentNullException(nameof(assemblyRepository));

    public override async Task<AssemblyDto> HandleInternalAsync(AddAssemblyCommand request, CancellationToken ct)
    {
        var result = await _assemblyRepository.InsertAsync(request.Assembly.ToAssemblyDto(), ct);
        return result.ToAssemblyDto();
    }
}