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
    public class AccountTransferMapping : IEntityTypeConfiguration<Transfer>
    {
        public void Configure(EntityTypeBuilder<Transfer> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.AccountNumberOrigin)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.AccountNumberTarger)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.ValueTransfer)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(p => p.Office)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.Status)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.TransferDate)
                .IsRequired()
                .HasColumnType("datetime");

            builder.ToTable("Transfers");
        }
    }
}
