using IS.Domain.Models.Enums;

namespace IS.Domain.Interfaces;

public interface IEntity<TId>
{
    TId Id { get; set; }
    Status Status { get; set; }
    DateTime CreatedOn { get; set; }
    string CreatedBy { get; set; }
    DateTime? ModifiedOn { get; set; }
    string? ModifiedBy { get; set; }
    DateTime? DeletedOn { get; set; }
    string? DeletedBy { get; set; }
}