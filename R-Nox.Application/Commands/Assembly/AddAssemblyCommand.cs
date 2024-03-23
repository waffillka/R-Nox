using MediatR;
using R_Nox.Services.Models.DTOs.Assembly;

namespace R_Nox.Services.Commands.Assembly;

public class AddAssemblyCommand(CreateAssemblyDto assembly) : IRequest<AssemblyDto>
{
    public CreateAssemblyDto Assembly { get; set; } = assembly;
}