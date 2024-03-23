using MediatR;
using R_Nox.Services.Models.DTOs.Assembly;

namespace R_Nox.Services.Queries.Assembly;

public class GetAssemblyByIdQuery(Guid assembly) : IRequest<AssemblyDto>
{
   public Guid Id { get; set; } = assembly;
}