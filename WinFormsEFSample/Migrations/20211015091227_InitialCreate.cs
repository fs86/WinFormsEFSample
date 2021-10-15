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
                values: new object[,]
                {
                    { new Guid("c7660f77-9962-45ee-a601-cfa7799aa85e"), "Anis" },
                    { new Guid("8fc4ae53-ec57-45a5-9788-daf495bd3111"), "Thymian" },
                    { new Guid("0a728168-51a5-4ad7-ac8c-876afce21b78"), "Schnittlauch" },
                    { new Guid("a6af90e8-c94d-4d55-86e7-0e3d523aa83d"), "Salbei" },
                    { new Guid("95d6e787-81a6-435c-a6a9-2aea905ec3d3"), "Petersilie" },
                    { new Guid("2587bd92-a90e-450b-9e78-bf0231a046dc"), "Oregano" },
                    { new Guid("f5af8933-3f28-4d0c-be9f-7c86743d25a0"), "Minze" },
                    { new Guid("16c08968-1869-439a-a403-4f9757b96594"), "Kümmel" },
                    { new Guid("0d6e5dd3-e41d-4cd5-a639-7c0a9d69549d"), "Wurzelpetersilie" },
                    { new Guid("4858c0fb-8a43-4b61-858c-9eb684bfbda5"), "Kresse" },
                    { new Guid("00579af1-2d77-4c4a-96fe-570ef0455cfe"), "Kerbel" },
                    { new Guid("a821d32e-0d32-4e94-bb0a-75568764bf15"), "Estragon" },
                    { new Guid("4236f6f6-bb89-4952-a60e-69bf87f461ab"), "Dill" },
                    { new Guid("c8d2c2e3-9fa0-4a85-a279-1d2e019b6cb0"), "Bärlauch" },
                    { new Guid("2b87619d-e0c6-4271-8a53-537e95c05d7e"), "Borretsch" },
                    { new Guid("1977d469-ef12-464c-bee6-03fc42ea1849"), "Bockshornklee" },
                    { new Guid("32f2a89a-d70d-4ebe-8ed5-69dab23501c8"), "Basilikum" },
                    { new Guid("0a5923c6-266c-4478-972d-4a8df335d658"), "Knoblauch" },
                    { new Guid("95010393-342e-4c36-90d0-8d5c9d0c13dc"), "Zitronenmelisse" }
                });

            migrationBuilder.InsertData(
                table: "Season",
                columns: new[] { "Id", "From", "HerbId", "To" },
                values: new object[,]
                {
                    { new Guid("8af96254-d025-4f5c-a56c-9b4cef659ca6"), "September", new Guid("c7660f77-9962-45ee-a601-cfa7799aa85e"), "November" },
                    { new Guid("28a1fd0c-1ad5-4045-aa3d-73dc96235a83"), "Januar", new Guid("0d6e5dd3-e41d-4cd5-a639-7c0a9d69549d"), "April" },
                    { new Guid("c9276dfd-ac0a-4a95-a3c1-dad38f38d3aa"), "März", new Guid("8fc4ae53-ec57-45a5-9788-daf495bd3111"), "Oktober" },
                    { new Guid("f4db0e30-ac74-44ce-9dbd-235675c94559"), "April", new Guid("0a728168-51a5-4ad7-ac8c-876afce21b78"), "Oktober" },
                    { new Guid("1118ee13-7d7b-4fcc-85b5-caaea124daad"), "April", new Guid("a6af90e8-c94d-4d55-86e7-0e3d523aa83d"), "November" },
                    { new Guid("341e37b3-6fd4-4db2-96f3-8d90e861f4a2"), "April", new Guid("95d6e787-81a6-435c-a6a9-2aea905ec3d3"), "Oktober" },
                    { new Guid("becc6315-8d28-43da-a16b-90925a460e13"), "April", new Guid("2587bd92-a90e-450b-9e78-bf0231a046dc"), "Oktober" },
                    { new Guid("4e7015ae-1e7e-4393-a1c9-ed94d0afc3a0"), "Mai", new Guid("f5af8933-3f28-4d0c-be9f-7c86743d25a0"), "September" },
                    { new Guid("0ef4791a-db80-4c47-8c9b-083dffddc014"), "August", new Guid("16c08968-1869-439a-a403-4f9757b96594"), "Oktober" },
                    { new Guid("0623177e-602b-4855-90ca-34b262c343c5"), "Oktober", new Guid("0d6e5dd3-e41d-4cd5-a639-7c0a9d69549d"), "Dezember" },
                    { new Guid("2e44a90e-2a59-47b3-b071-1e45e18512f8"), "Mai", new Guid("16c08968-1869-439a-a403-4f9757b96594"), "Mai" },
                    { new Guid("4ef6e92a-5165-4197-8ab3-3dfaaa056c1a"), "Juni", new Guid("0a5923c6-266c-4478-972d-4a8df335d658"), "August" },
                    { new Guid("3b2c6149-86ee-4444-b9b2-bb903515788d"), "April", new Guid("00579af1-2d77-4c4a-96fe-570ef0455cfe"), "Oktober" },
                    { new Guid("06b9c5a0-d6d9-40f5-b4b5-bf4eba20986a"), "Mai", new Guid("a821d32e-0d32-4e94-bb0a-75568764bf15"), "Oktober" },
                    { new Guid("6b99a058-93d3-47da-a5f0-2a614d253754"), "April", new Guid("4236f6f6-bb89-4952-a60e-69bf87f461ab"), "September" },
                    { new Guid("0c60496a-80dc-422c-8a93-3555c94634fa"), "März", new Guid("c8d2c2e3-9fa0-4a85-a279-1d2e019b6cb0"), "Juni" },
                    { new Guid("d1b60b24-0a69-4848-afcc-a8336e0c018c"), "Juni", new Guid("2b87619d-e0c6-4271-8a53-537e95c05d7e"), "August" },
                    { new Guid("0d3993d4-3848-4bdf-86dc-571dad3698bc"), "August", new Guid("1977d469-ef12-464c-bee6-03fc42ea1849"), "September" },
                    { new Guid("00b2619f-9536-4ce0-9e63-780c95f3bce5"), "Juni", new Guid("32f2a89a-d70d-4ebe-8ed5-69dab23501c8"), "September" },
                    { new Guid("c72ea7b9-e4c6-4a83-b1f1-22fccf8074df"), "Januar", new Guid("4858c0fb-8a43-4b61-858c-9eb684bfbda5"), "Dezember" },
                    { new Guid("b5a6f36a-27cb-4053-9472-8f781821d4e8"), "April", new Guid("95010393-342e-4c36-90d0-8d5c9d0c13dc"), "Oktober" }
                });

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
