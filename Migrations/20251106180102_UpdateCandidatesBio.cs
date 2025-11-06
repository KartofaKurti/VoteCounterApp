using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoteCounter.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCandidatesBio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Мъдър и далновиден лидер, който вярва в силата на знанието и последователните действия.", "/images/candidate1.jpg" });

            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Решителен и справедлив защитник на свободата на словото и обществения диалог.", "/images/candidate2.jpg" });

            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Идеалист с вяра в общността и социалната справедливост.", "/images/candidate3.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Амбициозен и всеотдаен човек с ясна визия за развитие и успех.", "/images/candidate1.jpg" });

            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Спокоен, решителен и вдъхновяващ лидер, готов да изслуша и помогне.", "/images/candidate2.jpg" });

            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Иновативен мислител с практичен подход и отдаденост на екипа.", "/images/candidate3.jpg" });
        }
    }
}
