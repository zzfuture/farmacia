using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class CRolPersona : IEntityTypeConfiguration<RolPersona>
    {
        public void Configure(EntityTypeBuilder<RolPersona> builder)
        {
            builder.ToTable("rolpersona");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id);
            builder.Property(c => c.NombreRolPersona).HasMaxLength(50);
        }
    }
}