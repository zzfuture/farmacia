using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class CContactoPersona : IEntityTypeConfiguration<ContactoPersona>
    {
        public void Configure(EntityTypeBuilder<ContactoPersona> builder)
        {
            builder.ToTable("contactopersona");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id);
            builder.HasOne(c => c.Personas).WithMany(c => c.ContactoPersonas).HasForeignKey(c => c.IdPersonaFk);
            builder.HasOne(c => c.TipoContactos).WithMany(c => c.ContactoPersonas).HasForeignKey(c => c.IdTipoContactoFk);
        }
    }
}