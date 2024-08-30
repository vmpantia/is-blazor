using Microsoft.EntityFrameworkCore;

namespace IS.Infrastructure.Databases.Contexts;

public class ISDbContext : DbContext
{
    public ISDbContext(DbContextOptions<ISDbContext> options) : base(options) { }
}