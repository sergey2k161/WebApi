using DataAccess;

namespace BussinessLogic;

internal class NoteService(INoteRepository noteRepository) : INoteService
{
    public async Task CreateAsync(string text, CancellationToken cancellationToken = default)
    {
        var note = new Note
        {
            Text = text
        };

        await noteRepository.CreateAsync(note, cancellationToken);
    }

    public async Task<string> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var note = await noteRepository.GetByIdAsync(id, cancellationToken);

        if( note is null)
        {
            throw new Exception("Note not found");
        }

        return note.Text;

    }
}
