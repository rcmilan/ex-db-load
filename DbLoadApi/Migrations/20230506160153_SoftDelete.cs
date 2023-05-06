using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbLoadApi.Migrations
{
    /// <inheritdoc />
    public partial class SoftDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "PlayerWeaponInventory");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "PlayerEquipmentInventory");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Player",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Player");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "PlayerWeaponInventory",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "PlayerEquipmentInventory",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
