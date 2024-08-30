using System.ComponentModel.DataAnnotations;
using IS.Domain.Interfaces;
using IS.Domain.Models.Enums;

namespace IS.Domain.Models.Entities;

public class Employee : IEntity<Guid>
{
    [Key]
    public required Guid Id { get; set; }
    
    public required string Email { get; set; }
    public required string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public required string LastName { get; set; }
    public required DateTime BirthDate { get; set; }
    public required Gender Gender { get; set; }
    public required string PhoneNumber { get; set; }
    public required string Address { get; set; }
    
    public required Status Status { get; set; }
    public required DateTime CreatedOn { get; set; }
    public required string CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? DeletedOn { get; set; }
    public string? DeletedBy { get; set; }
}