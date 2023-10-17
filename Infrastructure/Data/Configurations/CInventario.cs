using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class CInventario : IEntityTypeConfiguration<Inventario>
    {
        public void Configure(EntityTypeBuilder<Inventario> builder)
        {
            builder.ToTable("inventario");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasMaxLength(50);
            builder.Property(c => c.NombreInventario).IsRequired().HasMaxLength(50);
            builder.Property(c => c.PrecioInventario).HasColumnType("int");
            builder.Property(c => c.StockActual).HasColumnType("double");
            builder.Property(c => c.StockMinimo).HasColumnType("int");
            builder.Property(c => c.StockMaximo).HasColumnType("int");
            builder.HasOne(c => c.Productos).WithMany(p => p.Inventarios).HasForeignKey(c => c.IdProductoFk);
            builder.HasOne(c => c.Presentaciones).WithMany(p => p.Inventarios).HasForeignKey(c => c.IdPresentacionFk);
        }
    }
}