using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class CTipoContacto : IEntityTypeConfiguration<TipoContacto>
    {
        public void Configure(EntityTypeBuilder<TipoContacto> builder)
        {
            builder.ToTable("tipocontacto");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id);
            builder.Property(c => c.NombreTipoContacto).HasMaxLength(50);
        }
    }
}