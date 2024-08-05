
using Bookify.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Bookify.Infrastructure.Repositories;

public class Repository<T>
    where T : Entity
{
    protected readonly ApplicationDbContext DbContext;
    public Repository(ApplicationDbContext dbcontext)
    {
        DbContext = dbcontext;
    }
    public async Task<T?> GetByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        return await DbContext
            .Set<T>()
            .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public void Add(T entity)
    {
        DbContext.Add(entity);
    }
}
