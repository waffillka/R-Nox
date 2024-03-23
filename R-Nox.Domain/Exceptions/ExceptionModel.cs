namespace R_Nox.Domain.Exceptions;

public class ExceptionModel
{
    public string Error { get; set; } = "Internal server error";
    public int Status { get; set; } = 500;
}