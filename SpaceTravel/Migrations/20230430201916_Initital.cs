using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpaceTravel.Migrations
{
    public partial class Initital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Destination",
                columns: table => new
                {
                    DestinationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Url = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destination", x => x.DestinationId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "DestinationId", "Name", "Price", "Url" },
                values: new object[,]
                {
                    { 1, "Carina Nebula", "$1,295", "https://images-assets.nasa.gov/image/carina_nebula/carina_nebula~medium.jpg" },
                    { 2, "Helix Nebula", "$1,495", "https://images-assets.nasa.gov/image/PIA09178/PIA09178~medium.jpg" },
                    { 3, "Mars", "$1,095", "https://images-assets.nasa.gov/image/PIA21041/PIA21041~small.jpg" },
                    { 4, "Neptune ", "$2,295", "https://images-assets.nasa.gov/image/PIA01492/PIA01492~medium.jpg" },
                    { 5, "Blazar Black Hole", "$1,895", "https://images-assets.nasa.gov/image/PIA20912/PIA20912~small.jpg" },
                    { 6, "Crab Nebula", "$1,495", "https://images-assets.nasa.gov/image/PIA21474/PIA21474~small.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destination");
        }
    }
}
