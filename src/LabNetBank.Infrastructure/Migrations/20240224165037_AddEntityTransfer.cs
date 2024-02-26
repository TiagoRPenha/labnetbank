using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LabNetBank.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddEntityTransfer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transfers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountNumberOrigin = table.Column<string>(type: "varchar(100)", nullable: false),
                    AccountNumberTarger = table.Column<string>(type: "varchar(100)", nullable: false),
                    Office = table.Column<int>(type: "int", nullable: false),
                    ValueTransfer = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransferDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transfers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transfers");
        }
    }
}
