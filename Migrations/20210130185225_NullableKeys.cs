using Microsoft.EntityFrameworkCore.Migrations;

namespace horsesBackend.Migrations
{
    public partial class NullableKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Horses_Horses_DamId",
                table: "Horses");

            migrationBuilder.DropForeignKey(
                name: "FK_Horses_Horses_SireId",
                table: "Horses");

            migrationBuilder.AlterColumn<int>(
                name: "SireId",
                table: "Horses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DamId",
                table: "Horses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Horses_Horses_DamId",
                table: "Horses",
                column: "DamId",
                principalTable: "Horses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Horses_Horses_SireId",
                table: "Horses",
                column: "SireId",
                principalTable: "Horses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Horses_Horses_DamId",
                table: "Horses");

            migrationBuilder.DropForeignKey(
                name: "FK_Horses_Horses_SireId",
                table: "Horses");

            migrationBuilder.AlterColumn<int>(
                name: "SireId",
                table: "Horses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DamId",
                table: "Horses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Horses_Horses_DamId",
                table: "Horses",
                column: "DamId",
                principalTable: "Horses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Horses_Horses_SireId",
                table: "Horses",
                column: "SireId",
                principalTable: "Horses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
