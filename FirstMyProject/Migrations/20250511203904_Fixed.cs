using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstMyProject.Migrations
{
    /// <inheritdoc />
    public partial class Fixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_shoppingCartItems_Cakes_CakeID",
                table: "shoppingCartItems");

            migrationBuilder.RenameColumn(
                name: "CakeID",
                table: "shoppingCartItems",
                newName: "CakeId");

            migrationBuilder.RenameIndex(
                name: "IX_shoppingCartItems_CakeID",
                table: "shoppingCartItems",
                newName: "IX_shoppingCartItems_CakeId");

            migrationBuilder.RenameColumn(
                name: "CakeID",
                table: "Cakes",
                newName: "CakeId");

            migrationBuilder.RenameColumn(
                name: "ShortDiscription",
                table: "Cakes",
                newName: "ShortDescription");

            migrationBuilder.RenameColumn(
                name: "LongDiscription",
                table: "Cakes",
                newName: "LongDescription");

            migrationBuilder.RenameColumn(
                name: "IamgeUrl",
                table: "Cakes",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "IamgeThumbnailUrl",
                table: "Cakes",
                newName: "ImageThumbnailUrl");

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Orders",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Orders",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Orders",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine1",
                table: "Orders",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_shoppingCartItems_Cakes_CakeId",
                table: "shoppingCartItems",
                column: "CakeId",
                principalTable: "Cakes",
                principalColumn: "CakeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_shoppingCartItems_Cakes_CakeId",
                table: "shoppingCartItems");

            migrationBuilder.RenameColumn(
                name: "CakeId",
                table: "shoppingCartItems",
                newName: "CakeID");

            migrationBuilder.RenameIndex(
                name: "IX_shoppingCartItems_CakeId",
                table: "shoppingCartItems",
                newName: "IX_shoppingCartItems_CakeID");

            migrationBuilder.RenameColumn(
                name: "CakeId",
                table: "Cakes",
                newName: "CakeID");

            migrationBuilder.RenameColumn(
                name: "ShortDescription",
                table: "Cakes",
                newName: "ShortDiscription");

            migrationBuilder.RenameColumn(
                name: "LongDescription",
                table: "Cakes",
                newName: "LongDiscription");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Cakes",
                newName: "IamgeUrl");

            migrationBuilder.RenameColumn(
                name: "ImageThumbnailUrl",
                table: "Cakes",
                newName: "IamgeThumbnailUrl");

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine1",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddForeignKey(
                name: "FK_shoppingCartItems_Cakes_CakeID",
                table: "shoppingCartItems",
                column: "CakeID",
                principalTable: "Cakes",
                principalColumn: "CakeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
