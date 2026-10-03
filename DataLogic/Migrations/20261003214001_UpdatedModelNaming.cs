using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLogic.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedModelNaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeaponStats_Damage_DamageId",
                table: "WeaponStats");

            migrationBuilder.DropTable(
                name: "Damage");

            migrationBuilder.CreateTable(
                name: "WeaponDamage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total = table.Column<int>(type: "int", nullable: false),
                    Impact = table.Column<int>(type: "int", nullable: false),
                    Puncture = table.Column<float>(type: "real", nullable: false),
                    Slash = table.Column<float>(type: "real", nullable: false),
                    Heat = table.Column<int>(type: "int", nullable: false),
                    Cold = table.Column<int>(type: "int", nullable: false),
                    Electricity = table.Column<int>(type: "int", nullable: false),
                    Toxin = table.Column<int>(type: "int", nullable: false),
                    Blast = table.Column<int>(type: "int", nullable: false),
                    Radiation = table.Column<int>(type: "int", nullable: false),
                    Gas = table.Column<int>(type: "int", nullable: false),
                    Magnetic = table.Column<int>(type: "int", nullable: false),
                    Viral = table.Column<int>(type: "int", nullable: false),
                    Corrosive = table.Column<int>(type: "int", nullable: false),
                    Void = table.Column<int>(type: "int", nullable: false),
                    Tau = table.Column<int>(type: "int", nullable: false),
                    ShieldDrain = table.Column<int>(type: "int", nullable: false),
                    HealthDrain = table.Column<int>(type: "int", nullable: false),
                    EnergyDrain = table.Column<int>(type: "int", nullable: false),
                    True = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponDamage", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponStats_WeaponDamage_DamageId",
                table: "WeaponStats",
                column: "DamageId",
                principalTable: "WeaponDamage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeaponStats_WeaponDamage_DamageId",
                table: "WeaponStats");

            migrationBuilder.DropTable(
                name: "WeaponDamage");

            migrationBuilder.CreateTable(
                name: "Damage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Blast = table.Column<int>(type: "int", nullable: false),
                    Cold = table.Column<int>(type: "int", nullable: false),
                    Corrosive = table.Column<int>(type: "int", nullable: false),
                    Electricity = table.Column<int>(type: "int", nullable: false),
                    EnergyDrain = table.Column<int>(type: "int", nullable: false),
                    Gas = table.Column<int>(type: "int", nullable: false),
                    HealthDrain = table.Column<int>(type: "int", nullable: false),
                    Heat = table.Column<int>(type: "int", nullable: false),
                    Impact = table.Column<int>(type: "int", nullable: false),
                    Magnetic = table.Column<int>(type: "int", nullable: false),
                    Puncture = table.Column<float>(type: "real", nullable: false),
                    Radiation = table.Column<int>(type: "int", nullable: false),
                    ShieldDrain = table.Column<int>(type: "int", nullable: false),
                    Slash = table.Column<float>(type: "real", nullable: false),
                    Tau = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    Toxin = table.Column<int>(type: "int", nullable: false),
                    True = table.Column<int>(type: "int", nullable: false),
                    Viral = table.Column<int>(type: "int", nullable: false),
                    Void = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Damage", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponStats_Damage_DamageId",
                table: "WeaponStats",
                column: "DamageId",
                principalTable: "Damage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
