using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class CMovimientoInventario : IEntityTypeConfiguration<MovimientoInventario>
    {
        public void Configure(EntityTypeBuilder<MovimientoInventario> builder)
        {
            builder.ToTable("movimientoinventario");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasMaxLength(50);
            builder.Property(c => c.FechaMovimientoInventario).HasColumnType("date");
            builder.Property(c => c.FechaVencimiento).HasColumnType("date");
            builder.HasOne(c => c.Personas).WithMany(p => p.MovimientoInventarios).HasForeignKey(c => c.IdPersonaResponsableFk);
            builder.HasOne(c => c.Personas).WithMany(p => p.MovimientoInventarios).HasForeignKey(c => c.IdPersonaReceptorFk);
            builder.HasOne(c => c.TipoMovimientoInventarios).WithMany(p => p.MovimientoInventarios).HasForeignKey(c => c.IdTipoMovimientoInventarioFk);
            builder.HasOne(c => c.FormaPagos).WithMany(p => p.MovimientoInventarios).HasForeignKey(c => c.IdFormaPagoFk);
        }
    }
}