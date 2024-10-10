
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

internal class NoteRepository : INoteRepository
{
    private readonly ApplicatianDbContext _context;
    public NoteRepository(ApplicatianDbContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(Note note, CancellationToken cancellationToken = default)
    {
        note.Created = DateTime.UtcNow;

        await _context.Notes.AddAsync(note, cancellationToken);
        await _context.SaveChangesAsync();
    }

    public async Task<Note?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.Notes.FirstOrDefaultAsync(x =>  x.Id == id);
    }
}
