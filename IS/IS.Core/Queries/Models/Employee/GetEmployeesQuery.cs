using IS.Domain.Models.Dtos;
using MediatR;

namespace IS.Core.Queries.Models.Employee;

public record GetEmployeesQuery() : IRequest<IEnumerable<EmployeeDto>>;