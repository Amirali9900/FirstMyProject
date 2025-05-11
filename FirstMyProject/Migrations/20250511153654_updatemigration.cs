using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstMyProject.Migrations
{
    /// <inheritdoc />
    public partial class updatemigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ZipCose",
                table: "Orders",
                newName: "ZipCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Orders",
                newName: "ZipCose");
        }
    }
}
