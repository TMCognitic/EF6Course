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
    internal class CourConfiguration : ConfigurationBase<Cour>
    {
        public override void Configure(EntityTypeBuilder<Cour> builder)
        {
            builder.ToTable("Cour");

            builder.Property(c => c.Titre)
                .IsRequired()
                .HasColumnType("Binary(64)");
        }
    }
}
