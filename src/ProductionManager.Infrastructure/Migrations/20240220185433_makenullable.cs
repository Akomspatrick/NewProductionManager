using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductionManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class makenullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "vMin",
                table: "ModelVersions",
                type: "decimal(11,1)",
                precision: 11,
                scale: 1,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(11,1)",
                oldPrecision: 11,
                oldScale: 1);

            migrationBuilder.AlterColumn<int>(
                name: "nMax",
                table: "ModelVersions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "vMin",
                table: "ModelVersions",
                type: "decimal(11,1)",
                precision: 11,
                scale: 1,
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(11,1)",
                oldPrecision: 11,
                oldScale: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "nMax",
                table: "ModelVersions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
