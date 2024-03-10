using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eDentist.Services.Migrations
{
    /// <inheritdoc />
    public partial class newSeedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "BlogId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2024, 3, 10, 21, 11, 59, 562, DateTimeKind.Local).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "MedicalCard",
                keyColumn: "MedicalCardID",
                keyValue: 1,
                column: "datumDijagnoze",
                value: new DateTime(2024, 3, 10, 21, 11, 59, 562, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 3, 10, 21, 11, 59, 562, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 3, 10, 21, 11, 59, 562, DateTimeKind.Local).AddTicks(4686));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2024, 3, 10, 21, 7, 52, 809, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "BlogId", "Content", "CreatedAt", "Headline", "Slika" },
                values: new object[] { 1, "This is a sample blog post content.", new DateTime(2024, 3, 10, 21, 7, 52, 809, DateTimeKind.Local).AddTicks(644), "Sample Blog Post", null });

            migrationBuilder.UpdateData(
                table: "MedicalCard",
                keyColumn: "MedicalCardID",
                keyValue: 1,
                column: "datumDijagnoze",
                value: new DateTime(2024, 3, 10, 21, 7, 52, 809, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 3, 10, 21, 7, 52, 809, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 3, 10, 21, 7, 52, 809, DateTimeKind.Local).AddTicks(3273));
        }
    }
}
