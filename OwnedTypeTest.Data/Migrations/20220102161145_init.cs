using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OwnedTypeTest.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WithBoth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnedType_Value = table.Column<int>(type: "int", nullable: true),
                    OwnedType_MoreCoolData = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WithBoth", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WithOnes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnedType_Value = table.Column<int>(type: "int", nullable: true),
                    OwnedType_MoreCoolData = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WithOnes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WithOnesToTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WithOnesToTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OwnedTypeTwos",
                columns: table => new
                {
                    EntityOwnsOneOfEachId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    MoreCoolData = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnedTypeTwos", x => x.EntityOwnsOneOfEachId);
                    table.ForeignKey(
                        name: "FK_OwnedTypeTwos_WithBoth_EntityOwnsOneOfEachId",
                        column: x => x.EntityOwnsOneOfEachId,
                        principalTable: "WithBoth",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OwnedTypes",
                columns: table => new
                {
                    EntityOwnsOneToTableId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    MoreCoolData = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnedTypes", x => x.EntityOwnsOneToTableId);
                    table.ForeignKey(
                        name: "FK_OwnedTypes_WithOnesToTables_EntityOwnsOneToTableId",
                        column: x => x.EntityOwnsOneToTableId,
                        principalTable: "WithOnesToTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "WithBoth",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[,]
                {
                    { 1, "a@alpha.com", "Alpha" },
                    { 2, "b@bravo.com", "Bravo" },
                    { 3, "c@charlie.com", "Charlie" },
                    { 4, "d@delta.com", "Delta" },
                    { 5, "e@echo.com", "Echo" },
                    { 6, "f@foxtrot.com", "Foxtrot" },
                    { 7, "g@golf.com", "Golf" },
                    { 8, "h@hotel.com", "Hotel" },
                    { 9, "i@india.com", "India" },
                    { 10, "j@juliet.com", "Juliet" },
                    { 11, "k@kilo.com", "Kilo" },
                    { 12, "l@lima.com", "Lima" },
                    { 13, "m@mike.com", "Mike" },
                    { 14, "n@november.com", "November" },
                    { 15, "o@oscar.com", "Oscar" },
                    { 16, "p@papa.com", "Papa" },
                    { 17, "q@quebec.com", "Quebec" },
                    { 18, "r@romeo.com", "Romeo" },
                    { 19, "s@sierra.com", "Sierra" },
                    { 20, "t@tango.com", "Tango" },
                    { 21, "u@uniform.com", "Uniform" },
                    { 22, "v@victor.com", "Victor" },
                    { 23, "w@whiskey.com", "Whiskey" },
                    { 24, "x@x-ray.com", "X-Ray" },
                    { 25, "y@yankee.com", "Yankee" },
                    { 26, "z@zulu.com", "Zulu" }
                });

            migrationBuilder.InsertData(
                table: "WithOnes",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[,]
                {
                    { 1, "a@alpha.com", "Alpha" },
                    { 2, "b@bravo.com", "Bravo" },
                    { 3, "c@charlie.com", "Charlie" },
                    { 4, "d@delta.com", "Delta" },
                    { 5, "e@echo.com", "Echo" },
                    { 6, "f@foxtrot.com", "Foxtrot" },
                    { 7, "g@golf.com", "Golf" },
                    { 8, "h@hotel.com", "Hotel" },
                    { 9, "i@india.com", "India" },
                    { 10, "j@juliet.com", "Juliet" },
                    { 11, "k@kilo.com", "Kilo" },
                    { 12, "l@lima.com", "Lima" },
                    { 13, "m@mike.com", "Mike" },
                    { 14, "n@november.com", "November" },
                    { 15, "o@oscar.com", "Oscar" },
                    { 16, "p@papa.com", "Papa" }
                });

            migrationBuilder.InsertData(
                table: "WithOnes",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[,]
                {
                    { 17, "q@quebec.com", "Quebec" },
                    { 18, "r@romeo.com", "Romeo" },
                    { 19, "s@sierra.com", "Sierra" },
                    { 20, "t@tango.com", "Tango" },
                    { 21, "u@uniform.com", "Uniform" },
                    { 22, "v@victor.com", "Victor" },
                    { 23, "w@whiskey.com", "Whiskey" },
                    { 24, "x@x-ray.com", "X-Ray" },
                    { 25, "y@yankee.com", "Yankee" },
                    { 26, "z@zulu.com", "Zulu" }
                });

            migrationBuilder.InsertData(
                table: "WithOnesToTables",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[,]
                {
                    { 1, "a@alpha.com", "Alpha" },
                    { 2, "b@bravo.com", "Bravo" },
                    { 3, "c@charlie.com", "Charlie" },
                    { 4, "d@delta.com", "Delta" },
                    { 5, "e@echo.com", "Echo" },
                    { 6, "f@foxtrot.com", "Foxtrot" },
                    { 7, "g@golf.com", "Golf" },
                    { 8, "h@hotel.com", "Hotel" },
                    { 9, "i@india.com", "India" },
                    { 10, "j@juliet.com", "Juliet" },
                    { 11, "k@kilo.com", "Kilo" },
                    { 12, "l@lima.com", "Lima" },
                    { 13, "m@mike.com", "Mike" },
                    { 14, "n@november.com", "November" },
                    { 15, "o@oscar.com", "Oscar" },
                    { 16, "p@papa.com", "Papa" },
                    { 17, "q@quebec.com", "Quebec" },
                    { 18, "r@romeo.com", "Romeo" },
                    { 19, "s@sierra.com", "Sierra" },
                    { 20, "t@tango.com", "Tango" },
                    { 21, "u@uniform.com", "Uniform" },
                    { 22, "v@victor.com", "Victor" },
                    { 23, "w@whiskey.com", "Whiskey" },
                    { 24, "x@x-ray.com", "X-Ray" },
                    { 25, "y@yankee.com", "Yankee" },
                    { 26, "z@zulu.com", "Zulu" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OwnedTypes");

            migrationBuilder.DropTable(
                name: "OwnedTypeTwos");

            migrationBuilder.DropTable(
                name: "WithOnes");

            migrationBuilder.DropTable(
                name: "WithOnesToTables");

            migrationBuilder.DropTable(
                name: "WithBoth");
        }
    }
}
