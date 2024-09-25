using AS.Chat.Domain.Interfaces;

namespace AS.Chat.Domain.SeedWork;

public interface IGenericRepository<TAggregate> : IRepository where TAggregate: AggregateRoot<TAggregate>
{
    public Task Insert(TAggregate anAggregate, CancellationToken aCancellationToken);
    public Task<TAggregate> GetById(Guid id, CancellationToken aCancellationToken);
    public Task<IEnumerable<TAggregate>> GetAll();
}