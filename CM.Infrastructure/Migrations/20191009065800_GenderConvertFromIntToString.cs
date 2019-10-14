using Microsoft.EntityFrameworkCore.Migrations;

namespace CM.Infrastructure.Migrations
{
    public partial class GenderConvertFromIntToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Customer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Customer",
                type: "nvarchar(10)",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
