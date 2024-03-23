using MediatR;
using R_Nox.Services.Models.DTOs.Module;

namespace R_Nox.Services.Queries.Module;

public class GetModuleByIdQuery(Guid id) : IRequest<ModuleDto>
{
    public Guid Id { get; set; } = id;
}