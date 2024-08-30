using IS.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace IS.Infrastructure.Databases.Contexts;

public class ISDbContext : DbContext
{
    public ISDbContext(DbContextOptions<ISDbContext> options) : base(options) { }
    public DbSet<Employee> Employees { get; set; }
}