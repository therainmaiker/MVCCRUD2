using Microsoft.EntityFrameworkCore.Migrations;

namespace mvccccccccccccccccc.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    studentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "Varchar(100)", nullable: true),
                    LastName = table.Column<string>(type: "Varchar(100)", nullable: false),
                    CIN = table.Column<string>(type: "Varchar(100)", nullable: false),
                    Address = table.Column<string>(type: "Varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.studentID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
