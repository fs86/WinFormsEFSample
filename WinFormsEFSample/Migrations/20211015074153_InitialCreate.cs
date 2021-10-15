using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WinFormsEFSample.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Herb",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Herb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Season",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HerbId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Season", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Season_Herb_HerbId",
                        column: x => x.HerbId,
                        principalTable: "Herb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Herb",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("d6b2ae7f-82f4-4099-86a9-556a62338271"), "Anis" });

            migrationBuilder.InsertData(
                table: "Season",
                columns: new[] { "Id", "From", "HerbId", "To" },
                values: new object[] { new Guid("e358d618-d376-439a-9cd3-5e2c02849103"), "September", new Guid("d6b2ae7f-82f4-4099-86a9-556a62338271"), "November" });

            migrationBuilder.CreateIndex(
                name: "IX_Season_HerbId",
                table: "Season",
                column: "HerbId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Season");

            migrationBuilder.DropTable(
                name: "Herb");
        }
    }
}
