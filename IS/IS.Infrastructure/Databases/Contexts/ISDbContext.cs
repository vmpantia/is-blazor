using IS.Domain.Models.Entities;
using IS.Domain.Models.Enums;
using IS.Domain.Stubs;
using Microsoft.EntityFrameworkCore;

namespace IS.Infrastructure.Databases.Contexts;

public class ISDbContext : DbContext
{
    private readonly IEnumerable<Employee> _stubEmployees;

    public ISDbContext(DbContextOptions<ISDbContext> options) : base(options)
    {
        _stubEmployees = FakeData.Employee().Generate(1500);
    }
    
    public DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(emp =>
        {
            // Set initial data
            emp.HasData(_stubEmployees);
            
            // Set initial filter
            emp.HasQueryFilter(data => data.Status != Status.Deleted);
        });
    }
}