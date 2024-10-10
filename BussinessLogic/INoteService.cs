namespace BussinessLogic;

public interface INoteService
{
    Task CreateAsync(string text, CancellationToken cancellationToken = default);
    Task<string> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}
