namespace IS.Domain.Models.Dtos;

public class EmployeeDto
{
    public required Guid Id { get; set; }
    public required string Email { get; set; }
    public required string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public required string LastName { get; set; }
    public required DateTime BirthDate { get; set; }
    public required string Gender { get; set; }
    public required string PhoneNumber { get; set; }
    public required string Address { get; set; }
    public required string Status { get; set; }
    public required DateTime LastModifiedOn { get; set; }
    public required string LastModifiedBy { get; set; }
}