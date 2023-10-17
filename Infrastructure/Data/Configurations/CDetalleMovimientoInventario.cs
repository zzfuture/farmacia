using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class CDetalleMovimientoInventario : IEntityTypeConfiguration<DetalleMovimientoInventario>
    {
        public void Configure(EntityTypeBuilder<DetalleMovimientoInventario> builder)
        {
            builder.ToTable("detallemovimientoinventario");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id);
            builder.Property(c => c.Cantidad).HasColumnType("int");
            builder.Property(c => c.Precio).HasColumnType("int");
            builder.HasOne(c => c.Inventarios).WithMany(c => c.DetalleMovimientoInventarios).HasForeignKey(c => c.IdInventarioFk);
            builder.HasOne(c => c.MovimientoInventarios).WithMany(c => c.DetalleMovimientoInventarios).HasForeignKey(c => c.IdMovimientoInventarioFk);
        }
    }
}