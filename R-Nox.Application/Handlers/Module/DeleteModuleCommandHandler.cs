using MediatR;
using R_Nox.Db.Repositories.Interfaces;
using R_Nox.Services.Commands.Module;

namespace R_Nox.Services.Handlers.Module;

public class DeleteModuleCommandHandler : BaseRequestHandler<DeleteModuleCommand, Unit>
{
    private readonly IModuleRepository _moduleRepository;

    public DeleteModuleCommandHandler(IModuleRepository moduleRepository)
    {
        _moduleRepository = moduleRepository ?? throw new ArgumentNullException(nameof(moduleRepository));
    }


    public override async Task<Unit> HandleInternalAsync(DeleteModuleCommand request, CancellationToken ct = default)
    {
        await _moduleRepository.Delete(x => x.Id == request.Id, ct);
        return Unit.Value;
    }
}