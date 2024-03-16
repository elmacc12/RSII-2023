using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eDentist.Services.Migrations
{
    /// <inheritdoc />
    public partial class dataUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2024, 3, 13, 23, 6, 14, 614, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 6, 14, 616, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "MedicalCard",
                keyColumn: "MedicalCardID",
                keyValue: 1,
                column: "datumDijagnoze",
                value: new DateTime(2024, 3, 13, 23, 6, 14, 614, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 6, 14, 615, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 6, 14, 615, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 6, 14, 615, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 6, 14, 615, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 6, 14, 615, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 6, 14, 615, DateTimeKind.Local).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 6, 14, 615, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 6, 14, 615, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 9,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 6, 14, 615, DateTimeKind.Local).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 10,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 6, 14, 615, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 11,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 6, 14, 615, DateTimeKind.Local).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 12,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 6, 14, 615, DateTimeKind.Local).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 13,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 6, 14, 615, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 14,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 6, 14, 615, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 15,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 6, 14, 615, DateTimeKind.Local).AddTicks(6139));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2024, 3, 13, 23, 0, 36, 82, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 0, 36, 84, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "MedicalCard",
                keyColumn: "MedicalCardID",
                keyValue: 1,
                column: "datumDijagnoze",
                value: new DateTime(2024, 3, 13, 23, 0, 36, 82, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 0, 36, 83, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 0, 36, 83, DateTimeKind.Local).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 0, 36, 83, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 0, 36, 83, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 0, 36, 83, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 0, 36, 83, DateTimeKind.Local).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 0, 36, 83, DateTimeKind.Local).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 0, 36, 83, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 9,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 0, 36, 83, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 10,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 0, 36, 83, DateTimeKind.Local).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 11,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 0, 36, 83, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 12,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 0, 36, 83, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 13,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 0, 36, 83, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 14,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 0, 36, 83, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 15,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 23, 0, 36, 83, DateTimeKind.Local).AddTicks(6732));
        }
    }
}
