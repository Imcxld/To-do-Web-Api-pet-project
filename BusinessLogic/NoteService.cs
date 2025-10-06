using DAL;
using DAL.Models;
using System.Linq;

namespace BusinessLogic
{
    internal class NoteService(INoteRepository repository) : INoteService
    {
        public async Task CreateAsync(string title, string description, DateTime deadline, CancellationToken cancellationToken = default)
        {
            var note = new Note()
            {
                Title = title,
                Description = description,
                DeadLine = deadline
            };
            
            await repository.CreateAsync(note, cancellationToken);
        }

        public async Task<IEnumerable<Note>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var notes = await repository.GetAllNotesAsync(cancellationToken);
            return notes;
        }

        public async Task<Note> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID must be greater than 0", nameof(id));
            }

            var note = await repository.GetByIdAsync(id, cancellationToken) ?? throw new ArgumentException("Not found");
            return note;
        }

        public async Task UpdateAsync(int id, string newTitle, string newDescription, DateTime newDeadline, CancellationToken cancellationToken = default)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID must be greater than 0", nameof(id));
            }

            var note = await repository.GetByIdAsync(id, cancellationToken) ?? throw new ArgumentException("Not found");
            note.Title = newTitle;
            note.Description = newDescription;
            note.DeadLine = newDeadline;
            
            await repository.UpdateAsync(note, cancellationToken);
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID must be greater than 0", nameof(id));
            }

            var note = await repository.GetByIdAsync(id, cancellationToken) ?? throw new ArgumentException("Not found");
            
            await repository.DeleteAsync(note, cancellationToken);
        }

        public async Task<IEnumerable<Note>> GetActiveAsync(CancellationToken cancellationToken = default)
        {
            var notes = await repository.GetActiveNotesAsync(cancellationToken);
            return notes;
        }

        public async Task<IEnumerable<Note>> GetCompletedAsync(CancellationToken cancellationToken = default)
        {
            var notes = await repository.GetCompletedNotesAsync(cancellationToken);
            return notes;
        }

        public async Task MarkAsCompletedAsync(int id, CancellationToken cancellationToken = default)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID must be greater than 0", nameof(id));
            }

            var note = await repository.GetByIdAsync(id, cancellationToken) ?? throw new ArgumentException("Not found");

            await repository.MarkAsCompletedAsync(note, cancellationToken);
        }
    }
}
