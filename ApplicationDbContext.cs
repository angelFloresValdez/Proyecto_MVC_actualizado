

using Microsoft.EntityFrameworkCore;
using MyFirstProyectWithLineCommand.Entities;

public class ApplicactionDbContext : DbContext
{
    public ApplicactionDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Degree> Degrees { get; set; }
}