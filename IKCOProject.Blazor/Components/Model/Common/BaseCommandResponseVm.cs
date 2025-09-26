namespace IKCOProject.Blazor.Components.Model.Common;

public class BaseCommandResponseVm
{
    public int Id { get; set; }
    public bool? Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public List<string> Errors { get; set; } = new List<string>();
}