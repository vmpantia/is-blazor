using AutoMapper;
using IS.Core.Queries.Models.Employee;
using IS.Domain.Interfaces.Repositories;
using IS.Domain.Models.Dtos;
using MediatR;

namespace IS.Core.Queries.Handlers;

public class EmployeeQueryHandlers : 
    IRequestHandler<GetEmployeesQuery, IEnumerable<EmployeeDto>>,
    IRequestHandler<GetEmployeeByIdQuery, EmployeeDto>
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;
    public EmployeeQueryHandlers(IEmployeeRepository employeeRepository, IMapper mapper)
    {  
        _employeeRepository = employeeRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<EmployeeDto>> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
    {
        // Get employees from the database
        var employees = await _employeeRepository.GetEmployeesAsync(cancellationToken);
        
        // Check if the employees is NULL after getting it from the database.
        if(employees is null) throw new Exception("Employee cannot be NULL.");
        
        // Convert entities to dto
        var dto = _mapper.Map<IEnumerable<EmployeeDto>>(employees);

        return dto;
    }

    public async Task<EmployeeDto> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
    {
        // Get employee from the database.
        var employee = await _employeeRepository.GetByIdAsync(request.EmployeeId, cancellationToken);
        
        // Check if the employee is NULL after getting it from the database.
        if(employee is null) throw new Exception("Employee is not found in the database.");
        
        // Convert entity to dto
        var dto = _mapper.Map<EmployeeDto>(employee);

        return dto;
    }
}