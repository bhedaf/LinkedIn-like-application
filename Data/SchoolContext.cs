using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<WorkExp> WorkExp { get; set; }
        public DbSet<Education> Education { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<WorkExp>().ToTable("WorkExp");
            modelBuilder.Entity<Education>().ToTable("Education");
        }

        //public DbSet<ContosoUniversity.Models.Education> Education { get; set; }

        //public DbSet<ContosoUniversity.Models.WorkExp> WorkExps { get; set; }
    }
}