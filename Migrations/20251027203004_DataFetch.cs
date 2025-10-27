using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoteCounter.Migrations
{
    /// <inheritdoc />
    public partial class DataFetch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Амбициозен и всеотдаен човек с ясна визия за развитие и успех.", "Борислав Сапунджиев" });

            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Спокоен, решителен и вдъхновяващ лидер, готов да изслуша и помогне.", "Валентин Узунов" });

            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Иновативен мислител с практичен подход и отдаденост на екипа.", "Атанас Кьосеиванов" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Опитен лидер с визия за бъдещето.", "Кандидат 1" });

            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Млад и амбициозен с нови идеи.", "Кандидат 2" });

            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Човек на действието и резултатите.", "Кандидат 3" });
        }
    }
}
