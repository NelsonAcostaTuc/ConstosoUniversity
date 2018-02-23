using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get;set; }
        public DbSet<Enrollment> Enrollments { get;set; }
        public DbSet<Student> Students { get;set; }

           protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=127.0.0.1;Database=TestDB_user;User Id=sa;Password=Synagro1234;");
        }
    }   
}
  