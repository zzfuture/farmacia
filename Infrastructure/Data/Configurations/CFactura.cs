using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class CFactura : IEntityTypeConfiguration<Factura>
    {
        public void Configure(EntityTypeBuilder<Factura> builder)
        {
            builder.ToTable("factura");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id);
            builder.Property(c => c.FacturaActual);
            builder.Property(c => c.FacturaInicial);
            builder.Property(c => c.FacturaFinal);
            builder.Property(c => c.NumeroResolucion).HasMaxLength(50);
            builder.HasOne(c => c.Personas).WithMany(c => c.Facturas).HasForeignKey(c => c.IdPersonaFk);
            builder.HasOne(c => c.DetalleMovimientoInventarios).WithMany(c => c.Facturas).HasForeignKey(c => c.IdDetalleMovimientoInventarioFk);

        }
    }
}