using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class CUbicacionPersona : IEntityTypeConfiguration<UbicacionPersona>
    {
        public void Configure(EntityTypeBuilder<UbicacionPersona> builder)
        {
            builder.ToTable("ubicacionpersona");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id);
            builder.Property(c => c.TipoVia).HasMaxLength(50);
            builder.Property(c => c.NumeroPrincipal).HasColumnType("int");
            builder.Property(c => c.LetraPrincipal).HasMaxLength(50);
            builder.Property(c => c.Bis).HasMaxLength(50);
            builder.Property(c => c.LetraSecundaria).HasMaxLength(50);
            builder.Property(c => c.CardinalPrimario).HasMaxLength(50);
            builder.Property(c => c.NumeroSecundario).HasColumnType("int");
            builder.Property(c => c.LetraTerciaria).HasMaxLength(50);
            builder.Property(c => c.NumeroTerciario).HasColumnType("int");
            builder.Property(c => c.CardinalSecundario).HasMaxLength(50);
            builder.HasOne(c => c.Personas).WithOne(c => c.UbicacionPersonas).HasForeignKey<UbicacionPersona>(c => c.IdPersonaFk);
            builder.HasOne(c => c.Ciudades).WithMany(c => c.UbicacionPersonas).HasForeignKey(c => c.IdCiudadFk);
        }
    }
}