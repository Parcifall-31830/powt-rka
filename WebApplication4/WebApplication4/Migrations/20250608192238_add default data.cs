using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication4.Migrations
{
    /// <inheritdoc />
    public partial class adddefaultdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "IdGroup", "Name" },
                values: new object[,]
                {
                    { 1, "Grupa Informatyczna" },
                    { 2, "Grupa Prawnicza" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "IdStudent", "Age", "FirstName", "LastName" },
                values: new object[] { 1, 18, "John", "Doe" });

            migrationBuilder.InsertData(
                table: "StudentGroup",
                columns: new[] { "IdGroup", "IdStudent" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentGroup",
                keyColumns: new[] { "IdGroup", "IdStudent" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "StudentGroup",
                keyColumns: new[] { "IdGroup", "IdStudent" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "IdGroup",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "IdGroup",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "IdStudent",
                keyValue: 1);
        }
    }
}
