using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoteCounter.Migrations
{
    /// <inheritdoc />
    public partial class FixedURLs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/candidate1.jpg");

            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/candidate2.jpg");

            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/candidate3.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/borislav.jpg");

            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/valentin.jpg");

            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/atanas.jpg");
        }
    }
}
