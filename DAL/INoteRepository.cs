using DAL.Models;

namespace DAL
{
    public interface INoteRepository
    {
        Task CreateAsync(Note note, CancellationToken cancellationToken = default);

        Task<IEnumerable<Note>> GetAllNotesAsync(CancellationToken cancellationToken = default);

        Task<IEnumerable<Note>> GetActiveNotesAsync(CancellationToken cancellationToken = default);

        Task<IEnumerable<Note>> GetCompletedNotesAsync(CancellationToken cancellationToken = default);

        Task<Note?> GetByIdAsync(int id, CancellationToken cancellationToken = default);

        Task UpdateAsync(Note note, CancellationToken cancellationToken = default);

        Task DeleteAsync(Note note, CancellationToken cancellationToken = default);

        Task MarkAsCompletedAsync(Note note, CancellationToken cancellationToken = default);
    }
}
