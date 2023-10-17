using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class CPresentacion : IEntityTypeConfiguration<Presentacion>
    {
        public void Configure(EntityTypeBuilder<Presentacion> builder)
        {
            builder.ToTable("presentacion");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id);
            builder.Property(c => c.NombrePresentacion).HasMaxLength(50);
        }
    }
}