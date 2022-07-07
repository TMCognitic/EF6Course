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
    internal class SectionConfiguration : ConfigurationBase<Section>
    {
        public override void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.ToTable("Section");
        }
    }
}
