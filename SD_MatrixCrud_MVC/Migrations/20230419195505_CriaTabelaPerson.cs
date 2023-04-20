using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SD_MatrixCrud_MVC.Migrations
{
    /// <inheritdoc />
    public partial class CriaTabelaPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Peoples",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    Adress2 = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    Complement = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    City = table.Column<string>(type: "varchar(50)", nullable: true),
                    State = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peoples", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Peoples");
        }
    }
}
