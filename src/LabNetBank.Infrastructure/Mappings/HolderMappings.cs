using LabNetBank.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetBank.Infrastructure.Mappings
{
    public class HolderMappings : IEntityTypeConfiguration<Holder>
    {
        public void Configure(EntityTypeBuilder<Holder> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Email)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Phone)
                .IsRequired()
                .HasColumnType("varchar(11)");

            builder.Property(p => p.BirthData)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(p => p.UserType)
                .IsRequired()
                .HasColumnType("int");

            builder.ToTable("Holders");
        }
    }
}
