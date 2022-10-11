using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder) // What to do going up 
        {
            migrationBuilder.CreateTable(
                name: "Users", //creates a table called Users with 2 columns Id and UserName
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id); //Id is the primary key
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder) //what happens when you remove a migration which will just drop the table
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
