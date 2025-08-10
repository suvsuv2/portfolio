using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaxiCompany.Migrations
{
    /// <inheritdoc />
    public partial class Taxxi07 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DriverGoslingZ",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Cars = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverGoslingZ", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransportZ",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearofCreation = table.Column<int>(type: "int", nullable: false),
                    colour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Costable = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportZ", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ZakazzzZ",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNUmber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeofService = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adressClienta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adressKudaClienty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    codeTransporta = table.Column<int>(type: "int", nullable: false),
                    SummaZakaZa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZakazzzZ", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DriverGoslingZ");

            migrationBuilder.DropTable(
                name: "TransportZ");

            migrationBuilder.DropTable(
                name: "ZakazzzZ");
        }
    }
}
