using EF6Course.Context.Configurations;
using EF6Course.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EF6Course.Context
{
    public class UniversiteContext : DbContext
    {
        public DbSet<Etudiant> Etudiants
        {
            get
            {
                return Set<Etudiant>();
            }
        }
        public DbSet<Section> Sections
        {
            get
            {
                return Set<Section>();
            }
        }
        public DbSet<Cour> Cours
        {
            get
            {
                return Set<Cour>();
            }
        }

        //Configuration de Entity Framework
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MsSqlLocalDb; Initial Catalog=UniversityDb; Integrated Security=True;");

            //optionsBuilder.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information).EnableSensitiveDataLogging();            
        }

        //Configuration des entités (Cour, Etudiant, Section)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EtudiantConfiguration());
            modelBuilder.ApplyConfiguration(new CourConfiguration());
            modelBuilder.ApplyConfiguration(new SectionConfiguration());            
        }
    }
}