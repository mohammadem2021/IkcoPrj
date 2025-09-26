using IKCOProject.Application.Dtos.Note;
using IKCOProject.Domain.Entity;

namespace IKCOProject.Application.Contracts;

public interface INoteRepository
{
    public Task<Note> Add(Note note);
    public Task<List<Note>> GetAll();
    Task<Note?> Get(int id);
    public Task Remove(Note note);
}