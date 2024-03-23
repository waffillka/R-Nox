using MediatR;
using R_Nox.Services.Models.DTOs.Assembly;

namespace R_Nox.Services.Commands.Assembly;

public class DeleteAssemblyCommand(Guid id) : IRequest<Unit>
{
    public Guid Id { get; set; } = id;
}