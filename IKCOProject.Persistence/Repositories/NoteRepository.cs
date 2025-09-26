using IKCOProject.Application.Contracts;
using IKCOProject.Application.Dtos.Note;
using IKCOProject.Domain.Entity;
using IKCOProject.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace IKCOProject.Persistence.Repositories;

public class NoteRepository(ToDoDbContext dbContext) : INoteRepository
{
    private readonly ToDoDbContext _dbContext = dbContext;
    public async Task<Note> Add(Note note)
    {
        var result = await _dbContext.Notes.AddAsync(note);
        await _dbContext.SaveChangesAsync();
        return result.Entity;
    }

    public Task<List<Note>> GetAll()
    {
        return _dbContext.Notes.ToListAsync();
    }
    public Task<Note?> Get(int id)
    {
        return _dbContext.Notes.FirstOrDefaultAsync(r=>r.Id==id);
    }

    public async Task Remove(Note note)
    {
        _dbContext.Notes.Remove(note);
        await _dbContext.SaveChangesAsync();
    }
}