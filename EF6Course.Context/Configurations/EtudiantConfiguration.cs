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
                .HasColumnType("Date");
        }
    }
}
