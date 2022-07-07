using EF6Course.Context.Configurations;
using EF6Course.Entities;
using Microsoft.EntityFrameworkCore;

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