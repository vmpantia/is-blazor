using System.Linq.Expressions;
using IS.Domain.Models.Entities;

namespace IS.Domain.Interfaces.Repositories;

public interface IEmployeeRepository : IBaseRepository<Employee, Guid>
{
    Task<IEnumerable<Employee>> GetEmployeesAsync(CancellationToken cancellationToken = default);
    Task<IEnumerable<Employee>> GetEmployeesAsync(Expression<Func<Employee, bool>> predicate, CancellationToken cancellationToken = default);
}