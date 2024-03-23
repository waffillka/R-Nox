using MediatR;

namespace R_Nox.Services.Handlers;

public abstract class BaseRequestHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    /*protected ILoggerManager _logger;
    public BaseRequestHandler(ILoggerManager logger)
    {
        _logger = logger;
    }*/

    public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
    {
        // _logger.LogInfo($"Command is {typeof(TRequest)} return {typeof(TResponse)}");

        return HandleInternalAsync(request, cancellationToken);
    }

    public abstract Task<TResponse> HandleInternalAsync(TRequest request, CancellationToken cancellationToken);
}