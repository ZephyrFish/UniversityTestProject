using business_logic;

using Microsoft.EntityFrameworkCore;

namespace Data.DataAccess;

public class UniversityContext : DbContext
{
    public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
    {

    }

    public DbSet<Lection> Lection { get; set; }
    public DbSet<Lecturer> Lecturer { get; set; }
    public DbSet<Presence> Presence { get; set; }
    public DbSet<Homework> Homework { get; set; }
    public DbSet<Group> Group { get; set; }
    public DbSet<Student> Student { get; set; }
}
