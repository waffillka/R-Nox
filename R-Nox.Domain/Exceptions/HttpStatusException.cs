using System.Net;

namespace R_Nox.Domain.Exceptions;

public class HttpStatusException : Exception
{
    public HttpStatusCode StatusCode { get; }

    public HttpStatusException(HttpStatusCode statusCode)
    {
        StatusCode = statusCode;
    }

    public HttpStatusException()
    {
    }

    public HttpStatusException(HttpStatusCode statusCode, string message)
        : base(message)
    {
        StatusCode = statusCode;
    }
}