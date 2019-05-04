using Microsoft.EntityFrameworkCore.Migrations;

namespace FormCreatorMVC.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<string>(nullable: true),
                    CreatorName = table.Column<string>(nullable: false),
                    CreatorLastName = table.Column<string>(nullable: true),
                    CreatorAge = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => new { x.ID, x.CreatedBy });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Forms");
        }
    }
}
