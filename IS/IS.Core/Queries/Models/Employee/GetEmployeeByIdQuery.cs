using IS.Domain.Models.Dtos;
using MediatR;

namespace IS.Core.Queries.Models.Employee;

public sealed record GetEmployeeByIdQuery(Guid EmployeeId) : IRequest<EmployeeDto>;