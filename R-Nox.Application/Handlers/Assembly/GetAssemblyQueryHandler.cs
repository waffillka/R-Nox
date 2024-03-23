using System.Globalization;
using System.Net;
using R_Nox.Db.Repositories.Interfaces;
using R_Nox.Domain.Exceptions;
using R_Nox.Services.Mappers;
using R_Nox.Services.Models.DTOs.Assembly;
using R_Nox.Services.Queries.Assembly;

namespace R_Nox.Services.Handlers.Assembly;

public class GetAssemblyQueryHandler(IAssemblyRepository assemblyRepository)
    : BaseRequestHandler<GetAssemblyByIdQuery, AssemblyDto>
{
    private readonly IAssemblyRepository _assemblyRepository = assemblyRepository ?? throw new ArgumentNullException(nameof(assemblyRepository));

    public override async Task<AssemblyDto> HandleInternalAsync(GetAssemblyByIdQuery request, CancellationToken ct)
    {
        var result = await _assemblyRepository.GetAsync(x => x.Id == request.Id, ct);
        
        if (result == null)
        {
            throw new HttpStatusException(HttpStatusCode.NotFound, "Cannot find assembly.");
        }
        
        return result.ToAssemblyDto();
    }
}