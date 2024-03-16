﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eDentist.Services.Migrations
{
    /// <inheritdoc />
    public partial class ProductModification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2024, 3, 13, 23, 0, 36, 82, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "BlogId", "Content", "CreatedAt", "Headline", "Slika" },

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "StateMachine",
                value: "draft");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "StateMachine",
                value: "draft");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "StateMachine",
                value: "draft");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "StateMachine",
                value: "draft");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "StateMachine",
                value: "draft");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                column: "StateMachine",
                value: "draft");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                column: "StateMachine",
                value: "draft");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8,
                column: "StateMachine",
                value: "draft");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9,
                column: "StateMachine",
                value: "draft");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10,
                column: "StateMachine",
                value: "draft");

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TranskcijaId",
                keyValue: 2,
                column: "TransId",
                value: "PAYID-MXPGHDI82U242769W004564J");

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TranskcijaId", "Amount", "OrderHeaderId", "TransId", "TransactionStatus" },
                values: new object[,]
                {
                    { 3, 30.0, 3, "PAYID-MXPGHDI82U242769W004564J", "Success" },
                    { 4, 40.0, 4, "PAYID-MXPGHDI82U242769W004564J", "Success" },
                    { 5, 50.0, 5, "PAYID-MXPGHDI82U242769W004564J", "Success" },
                    { 6, 60.0, 6, "PAYID-MXPGHDI82U242769W004564J", "Success" },
                    { 7, 70.0, 7, "PAYID-MXPGHDI82U242769W004564J", "Success" },
                    { 8, 80.0, 8, "PAYID-MXPGHDI82U242769W004564J", "Success" },
                    { 9, 90.0, 9, "PAYID-MXPGHDI82U242769W004564J", "Success" },
                    { 10, 100.0, 10, "PAYID-MXPGHDI82U242769W004564J", "Success" },
                    { 11, 110.0, 11, "PAYID-MXPGHDI82U242769W004564J", "Success" },
                    { 12, 120.0, 12, "PAYID-MXPGHDI82U242769W004564J", "Success" },
                    { 13, 130.0, 13, "PAYID-MXPGHDI82U242769W004564J", "Success" },
                    { 14, 140.0, 14, "PAYID-MXPGHDI82U242769W004564J", "Success" },
                    { 15, 150.0, 15, "PAYID-MXPGHDI82U242769W004564J", "Success" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "BlogId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TranskcijaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TranskcijaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TranskcijaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TranskcijaId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TranskcijaId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TranskcijaId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TranskcijaId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TranskcijaId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TranskcijaId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TranskcijaId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TranskcijaId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TranskcijaId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TranskcijaId",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2024, 3, 13, 19, 29, 24, 518, DateTimeKind.Local).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "MedicalCard",
                keyColumn: "MedicalCardID",
                keyValue: 1,
                column: "datumDijagnoze",
                value: new DateTime(2024, 3, 13, 19, 29, 24, 518, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 19, 29, 24, 519, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 19, 29, 24, 519, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 19, 29, 24, 519, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 19, 29, 24, 519, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 19, 29, 24, 519, DateTimeKind.Local).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 19, 29, 24, 519, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 19, 29, 24, 519, DateTimeKind.Local).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 19, 29, 24, 519, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 9,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 19, 29, 24, 519, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 10,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 19, 29, 24, 519, DateTimeKind.Local).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 11,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 19, 29, 24, 519, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 12,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 19, 29, 24, 519, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 13,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 19, 29, 24, 519, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 14,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 19, 29, 24, 519, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 15,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 19, 29, 24, 519, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "StateMachine",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "StateMachine",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "StateMachine",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "StateMachine",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "StateMachine",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                column: "StateMachine",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                column: "StateMachine",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8,
                column: "StateMachine",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9,
                column: "StateMachine",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10,
                column: "StateMachine",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TranskcijaId",
                keyValue: 2,
                column: "TransId",
                value: "PAYID-MXPGFSA64135549VN997594K");
        }
    }
}