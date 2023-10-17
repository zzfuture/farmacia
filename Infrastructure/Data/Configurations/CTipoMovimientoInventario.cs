using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class CTipoMovimientoInventario : IEntityTypeConfiguration<TipoMovimientoInventario>
    {
        public void Configure(EntityTypeBuilder<TipoMovimientoInventario> builder)
        {
            builder.ToTable("tipomovimientoinventario");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id);
            builder.Property(c => c.NombreTipoMovimientoInventario).HasMaxLength(50);
        }
    }
}