using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class CDepartamento : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            builder.ToTable("departamento");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id);
            builder.Property(c => c.NombreDepartamento).HasMaxLength(50);
            builder.HasOne(c => c.Paises).WithMany(c => c.Departamentos).HasForeignKey(c => c.IdPaisFk);
        }
    }
}