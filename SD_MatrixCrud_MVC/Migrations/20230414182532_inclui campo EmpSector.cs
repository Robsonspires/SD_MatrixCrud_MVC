using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SD_MatrixCrud_MVC.Migrations
{
    /// <inheritdoc />
    public partial class incluicampoEmpSector : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmpSector",
                table: "Employees",
                type: "varchar(50)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpSector",
                table: "Employees");
        }
    }
}
