using MediatR;
using R_Nox.Db.Repositories.Interfaces;
using R_Nox.Services.Commands.Assembly;

namespace R_Nox.Services.Handlers.Assembly;

public class DeleteAssemblyCommandHandler : BaseRequestHandler<DeleteAssemblyCommand, Unit>
{
    private readonly IAssemblyRepository _assemblyRepository;

    public DeleteAssemblyCommandHandler(IAssemblyRepository assemblyRepository)
    {
        _assemblyRepository = assemblyRepository ?? throw new ArgumentNullException(nameof(assemblyRepository));
    }

    public override async Task<Unit> HandleInternalAsync(DeleteAssemblyCommand request, CancellationToken ct)
    {
        await _assemblyRepository.Delete(x => x.Id == request.Id, ct);
        return Unit.Value;
    }
}