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
    public class AccountMapping : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.AccountNumber)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.Office)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.Balance)
                .HasColumnType("decimal(18,2)");

            builder.Property(p => p.AccountType)
                .IsRequired()
                .HasColumnType("int");

            builder.ToTable("Accounts");
        }
    }
}
