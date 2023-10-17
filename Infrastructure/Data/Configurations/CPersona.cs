using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class CPersona : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("persona");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasMaxLength(50);
            builder.Property(c => c.NombrePersona);
            builder.Property(c => c.FechaRegistroPersona).HasColumnType("date");
            builder.HasOne(c => c.RolPersonas).WithMany(c => c.Personas).HasForeignKey(c => c.IdRolPersonaFk);
            builder.HasOne(c => c.TipoDocumentos).WithMany(c => c.Personas).HasForeignKey(c => c.IdTipoDocumentoFk);
            builder.HasOne(c => c.TipoPersonas).WithMany(c => c.Personas).HasForeignKey(c => c.IdTipoPersonaFk);
            // builder.HasOne(c => c.UbicacionPersonas).WithMany(c => c.Personas); Porque da error???

        }
    }
}