using FluentValidation.Results;

namespace IKCOProject.Application.Response;

public class BaseCommandResponse
{
    public int Id { get; set; }
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public List<string> Errors { get; set; } = new List<string>();
    public BaseCommandResponse(string errors)
    {
        this.Success = false;
        Errors = [errors];
    }
    public BaseCommandResponse(List<string> errors)
    {
        this.Success = false;
        Errors = errors;
    }
    public BaseCommandResponse(int id, string message)
    {
        this.Id = id;
        this.Success = true;
        this.Message = message;
    }

    public BaseCommandResponse(ValidationResult errors)
    {
        this.Success = false;
        this.Errors = errors.Errors.Select(e => e.ErrorMessage).ToList();
    }
}