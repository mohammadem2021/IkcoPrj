namespace IKCOProject.Application.Dtos.Note;

public class NoteDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Content { get; set; }
    public DateTime CreatedAt { get; set; }
}