using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class CTipoDocumento : IEntityTypeConfiguration<TipoDocumento>
    {
        public void Configure(EntityTypeBuilder<TipoDocumento> builder)
        {
            builder.ToTable("tipodocumento");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id);
            builder.Property(c => c.NombreTipoDocumento).HasMaxLength(50);
        }
    }
}