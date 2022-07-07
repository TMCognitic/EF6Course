using EF6Course.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Course.Context.Configurations
{
    internal class EtudiantConfiguration : ConfigurationBase<Etudiant>
    {
        public override void Configure(EntityTypeBuilder<Etudiant> builder)
        {
            builder.ToTable("Etudiant");
            builder.Property(e => e.Nom)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(e => e.Prenom)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(384);
            builder.Property(e => e.DateInscription)
                .IsRequired()
                .HasColumnType("Date")
                //Ajoute une valeur par défaut
                .HasDefaultValueSql("GETDATE()");
            builder.Property(e => e.SectionId)
                .IsRequired();

            //Ajoute une contraint check
            builder.HasCheckConstraint("CK_Etudiant_Resultat", "(Resultat BETWEEN 0 AND 20)");

            //Ajoute une contraint unique sur un champs
            builder.HasIndex(e => e.Email).IsUnique();
            //Ajoute une contraint unique sur plusieurs champs
            //builder.HasIndex(e => new { e.Nom, e.Prenom }).IsUnique();

            //Si pas de propriété de navigation
            //builder.HasOne<Section>()
            //    .WithMany()
            //    .HasForeignKey("SectionId")
            //    .OnDelete(DeleteBehavior.NoAction);

            //Si propriété de navigation on peut le définir explicitement
            //ou pour définir un behavior autre que celui par défaut
            builder.HasOne(e => e.Section)
                .WithMany(s => s.Etudiants)
                .HasForeignKey("SectionId")
                .OnDelete(DeleteBehavior.NoAction);

            //builder.HasMany(e => e.Inscriptions)
            //    .WithOne()
            //    .HasForeignKey("EtudiantId");


            builder.HasMany(e => e.Cours)
                .WithMany(c => c.Etudiants)
                .UsingEntity<Inscription>(
                i => i.HasOne<Cour>().WithMany().HasForeignKey(i => i.CourId),
                i => i.HasOne<Etudiant>().WithMany().HasForeignKey(i => i.EtudiantId), 
                (builder) => {
                    builder.ToTable("Inscription").HasKey(i => new { i.EtudiantId, i.CourId, i.Year });
                });
        }
    }
}
