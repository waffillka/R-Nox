using System.Globalization;
using R_Nox.Db.Repositories.Interfaces;
using R_Nox.Services.Mappers;
using R_Nox.Services.Models.DTOs.Assembly;
using R_Nox.Services.Queries.Assembly;

namespace R_Nox.Services.Handlers.Assembly;

public class GetAssemblyQueryHandler : BaseRequestHandler<GetAssemblyByIdQuery, AssemblyDto>
{
    private readonly IAssemblyRepository _assemblyRepository;

    public GetAssemblyQueryHandler(IAssemblyRepository assemblyRepository)
    {
        _assemblyRepository = assemblyRepository ?? throw new ArgumentNullException(nameof(assemblyRepository));
    }

    public override async Task<AssemblyDto> HandleInternalAsync(GetAssemblyByIdQuery request, CancellationToken ct)
    {
        var result = await _assemblyRepository.GetAsync(x => x.Id == request.Id, ct);
        
        if (result == null)
        {
            //throw new NotFoundException();
        }
        
        return result.ToAssemblyDto();
    }
}