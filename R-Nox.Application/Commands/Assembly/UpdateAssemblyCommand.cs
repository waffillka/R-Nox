using MediatR;
using R_Nox.Services.Models.DTOs.Assembly;

namespace R_Nox.Services.Commands.Assembly;

public class UpdateAssemblyCommand(AssemblyDto assembly) : IRequest<AssemblyDto>
{
    public AssemblyDto Assembly { get; set; } = assembly;
}