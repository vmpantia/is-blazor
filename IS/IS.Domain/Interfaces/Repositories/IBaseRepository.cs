using System.Linq.Expressions;

namespace IS.Domain.Interfaces.Repositories;

public interface IBaseRepository<TEntity, TId> 
    where TEntity : IEntity<TId> 
{
    IQueryable<TEntity> GetAll();
    IQueryable<TEntity> GetByExpression(Expression<Func<TEntity, bool>> predicate);
    Task<TEntity?> GetByIdAsync(TId id, CancellationToken cancellationToken = default);
    Task<TEntity?> GetOneAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);
    TEntity? GetOne(Expression<Func<TEntity, bool>> predicate);
    bool IsExist(Expression<Func<TEntity, bool>> predicate, out TEntity entity);
    Task AddAsync(TEntity entity, CancellationToken cancellationToken = default);
    void Update(TEntity entity);
    void Remove(TEntity entity);
}