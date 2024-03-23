using MediatR;

namespace R_Nox.Services.Commands.Module;

public class DeleteModuleCommand(Guid id) : IRequest<Unit>
{
    public Guid Id { get; set; } = id;
}