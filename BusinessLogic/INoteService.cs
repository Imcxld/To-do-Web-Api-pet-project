using DAL.Models;

namespace BusinessLogic
{
    public interface INoteService
    {
        Task CreateAsync(string title, string descrtiption, DateTime deadline, CancellationToken cancellationToken = default);

        Task<IEnumerable<Note>> GetAllAsync(CancellationToken cancellationToken = default);

        Task<IEnumerable<Note>> GetActiveAsync(CancellationToken cancellationToken = default);

        Task<IEnumerable<Note>> GetCompletedAsync(CancellationToken cancellationToken = default);

        Task<Note> GetByIdAsync(int id, CancellationToken cancellationToken = default);

        Task UpdateAsync(int id, string newTitle, string newDescription, DateTime newDeadline, CancellationToken cancellationToken = default);

        Task DeleteAsync(int id, CancellationToken cancellationToken = default);

        Task MarkAsCompletedAsync(int id, CancellationToken cancellationToken = default);
    }
}
