namespace IKCOProject.Application.Dtos.Note;

public class CreateNoteDto
{
    public string Title { get; set; } = string.Empty;
    public string? Content { get; set; }
}