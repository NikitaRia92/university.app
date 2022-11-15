using Microsoft.EntityFrameworkCore;
using University.Domain.Models;
using University.Infrastructure.EntityModels;

namespace University.Infrastructure
{
    public class ApplicationContext : DbContext
    {
        
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        {

        }

        
        public virtual DbSet<ConfirmationEnrollment> ConfirmationEnrollments { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<FormedGroup> FormedGroups { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Speciality> Specialities { get; set; }
        public virtual DbSet<Statement> Statements { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FacultyEntityModel).Assembly);
        }

    }
}
