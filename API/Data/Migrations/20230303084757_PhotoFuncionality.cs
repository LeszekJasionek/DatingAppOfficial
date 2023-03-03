using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class PhotoFuncionality : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicedId",
                table: "Photos");

            migrationBuilder.AddColumn<string>(
                name: "PublicId",
                table: "Photos",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicId",
                table: "Photos");

            migrationBuilder.AddColumn<int>(
                name: "PublicedId",
                table: "Photos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
