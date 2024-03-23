using System.Net;
using R_Nox.Domain.Exceptions;
using System.Text.Json;
using Newtonsoft.Json;

namespace R_Nox.Middlewares;


public class GlobalExceptionHandlerMiddleware(RequestDelegate next)
{
    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await next(context);
        }
        catch (Exception exception)
        {
            await HandleExceptionAsync(context, exception);
        }
    }

    private Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        var code = (int)HttpStatusCode.InternalServerError;
        var message = new ExceptionModel();

        if (exception is HttpStatusException apiException)
        {
            code = (int)apiException.StatusCode;
            message.Status = (int)apiException.StatusCode;
            message.Error = apiException?.Message ?? exception.Message;
        }

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = code;

        return context.Response.WriteAsync(JsonConvert.SerializeObject(message));
    }
}