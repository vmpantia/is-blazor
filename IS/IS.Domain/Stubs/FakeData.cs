using Bogus;
using IS.Domain.Models.Entities;
using IS.Domain.Models.Enums;

namespace IS.Domain.Stubs;

public class FakeData
{
    public static Faker<Employee> Employee() =>
        new Faker<Employee>()
            .RuleFor(prop => prop.Id, f => f.Random.Guid())
            .RuleFor(prop => prop.Email, f => f.Person.Email)
            .RuleFor(prop => prop.FirstName, f => f.Name.FirstName())
            .RuleFor(prop => prop.LastName, f => f.Name.LastName())
            .RuleFor(prop => prop.BirthDate, f => f.Date.Past())
            .RuleFor(prop => prop.Gender, f => f.PickRandom<Gender>())
            .RuleFor(prop => prop.PhoneNumber, f => f.Phone.PhoneNumber())
            .RuleFor(prop => prop.Address, f => f.Address.StreetAddress())
            .RuleFor(prop => prop.Status, f => f.PickRandom<Status>())
            .RuleFor(prop => prop.CreatedOn, f => f.Date.Past())
            .RuleFor(prop => prop.CreatedBy, f => f.Person.Email);
}