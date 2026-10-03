using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLogic.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Damage",
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
                    table.PrimaryKey("PK_Damage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeaponStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DamagePerShot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalDamage = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CriticalChance = table.Column<float>(type: "real", nullable: false),
                    CriticalMultiplier = table.Column<float>(type: "real", nullable: false),
                    ProcChance = table.Column<float>(type: "real", nullable: false),
                    FireRate = table.Column<float>(type: "real", nullable: false),
                    MasteryReq = table.Column<int>(type: "int", nullable: false),
                    ProductCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Accuracy = table.Column<float>(type: "real", nullable: false),
                    OmegaAttenuation = table.Column<float>(type: "real", nullable: false),
                    Trigger = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MagazineSize = table.Column<int>(type: "int", nullable: false),
                    ReloadTime = table.Column<int>(type: "int", nullable: false),
                    Multishot = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DamageId = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Polarities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExilusPolarity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Disposition = table.Column<int>(type: "int", nullable: false),
                    IsPrime = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeaponStats_Damage_DamageId",
                        column: x => x.DamageId,
                        principalTable: "Damage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeaponStats_DamageId",
                table: "WeaponStats",
                column: "DamageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeaponStats");

            migrationBuilder.DropTable(
                name: "Damage");
        }
    }
}
