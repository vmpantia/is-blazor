using System.Linq.Expressions;
using IS.Domain.Interfaces;
using IS.Infrastructure.Databases.Contexts;
using Microsoft.EntityFrameworkCore;

namespace IS.Infrastructure.Databases.Repositories;

public class BaseRepository<TEntity, TId> : IBaseRepository<TEntity, TId> where TEntity : class, IEntity<TId>
{
    private readonly ISDbContext _context;
    private readonly DbSet<TEntity> _table;

    public BaseRepository(ISDbContext context)
    {
        _context = context;
        _table = context.Set<TEntity>();
    }

    public IQueryable<TEntity> GetAll() =>
        _table.AsQueryable();

    public IQueryable<TEntity> GetByExpression(Expression<Func<TEntity, bool>> predicate) =>
        _table.AsQueryable().Where(predicate);

    public async Task<TEntity?> GetByIdAsync(TId id, CancellationToken cancellationToken = default) =>
        await _table.FindAsync(id, cancellationToken);

    public async Task<TEntity?> GetOneAsync(Expression<Func<TEntity, bool>> predicate,
        CancellationToken cancellationToken = default) =>
        await _table.FirstOrDefaultAsync(predicate, cancellationToken);

    public async Task AddAsync(TEntity entity, CancellationToken cancellationToken = default) =>
        await _table.AddAsync(entity, cancellationToken);

    public void Update(TEntity entity) => _table.Update(entity);

    public void Remove(TEntity entity) => _table.Remove(entity);
}