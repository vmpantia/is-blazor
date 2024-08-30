using System.Linq.Expressions;
using IS.Domain.Interfaces.Repositories;
using IS.Domain.Models.Entities;
using IS.Infrastructure.Databases.Contexts;
using Microsoft.EntityFrameworkCore;

namespace IS.Infrastructure.Databases.Repositories;

public class EmployeeRepository : BaseRepository<Employee, Guid>, IEmployeeRepository
{
    public EmployeeRepository(ISDbContext context) : base(context) { }

    public async Task<IEnumerable<Employee>> GetEmployeesAsync(CancellationToken cancellationToken = default) =>
        await base.GetAll().ToListAsync(cancellationToken);

    public async Task<IEnumerable<Employee>> GetEmployeesAsync(Expression<Func<Employee, bool>> predicate, CancellationToken cancellationToken = default) =>
        await base.GetByExpression(predicate).ToListAsync(cancellationToken);
}