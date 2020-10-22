using Microsoft.EntityFrameworkCore.Migrations;

namespace CCB_Administrativo.Migrations
{
    public partial class statusObreiro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Obreiros",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Obreiros");
        }
    }
}
