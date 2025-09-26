using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace IKCOProject.Blazor.Components.Model;

public class NoteVm
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Content { get; set; }
    public DateTime CreatedAt { get; set; }
}
public class CreateNoteVm
{
    [Required(ErrorMessage = "نمیتواند خالی باشد")]
    public string Title { get; set; } = string.Empty;
    public string? Content { get; set; }
}