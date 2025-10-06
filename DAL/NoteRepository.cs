using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    internal class NoteRepository(ToDoAppContext context) : INoteRepository
    {
        public async Task CreateAsync(Note note, CancellationToken cancellationToken = default)
        {
            note.CreatedAt = DateTime.UtcNow;
            note.IsCompleted = false;
            await context.Notes.AddAsync(note, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteAsync(Note note, CancellationToken cancellationToken = default)
        {
            context.Remove(note);
            await context.SaveChangesAsync(cancellationToken);
        }

        public async Task<IEnumerable<Note>> GetActiveNotesAsync(CancellationToken cancellationToken = default)
        {
            return await context.Notes.AsNoTracking()
                .Where(x => x.IsCompleted == false)
                .OrderBy(x => x.DeadLine)
                .ToListAsync();
        }

        public async Task<IEnumerable<Note>> GetAllNotesAsync(CancellationToken cancellationToken = default)
        {
            return await context.Notes.AsNoTracking().OrderByDescending(x => x.CreatedAt).ToListAsync(cancellationToken);
        }

        public async Task<Note?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await context.Notes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Note>> GetCompletedNotesAsync(CancellationToken cancellationToken = default)
        {
            return await context.Notes.AsNoTracking()
                .Where(x => x.IsCompleted == true)
                .OrderBy(x => x.CreatedAt)
                .ToListAsync();
        }

        public async Task MarkAsCompletedAsync(Note note, CancellationToken cancellationToken = default)
        {
            note.IsCompleted = true;
            context.Notes.Update(note);
            await context.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateAsync(Note note, CancellationToken cancellationToken = default)
        {
            context.Notes.Update(note);
            await context.SaveChangesAsync(cancellationToken);
        }
    }
}
