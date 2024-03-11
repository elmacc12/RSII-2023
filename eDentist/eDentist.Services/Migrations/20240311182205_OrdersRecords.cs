using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eDentist.Services.Migrations
{
    /// <inheritdoc />
    public partial class OrdersRecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2024, 3, 11, 19, 22, 5, 550, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "MedicalCard",
                keyColumn: "MedicalCardID",
                keyValue: 1,
                column: "datumDijagnoze",
                value: new DateTime(2024, 3, 11, 19, 22, 5, 550, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 3, 11, 19, 22, 5, 550, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 2,
                columns: new[] { "OrderDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 22, 5, 550, DateTimeKind.Local).AddTicks(5627), null });

            migrationBuilder.InsertData(
                table: "OrderHeader",
                columns: new[] { "OrderHeaderID", "OrderDate", "Status", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { 3, new DateTime(2024, 3, 11, 19, 22, 5, 550, DateTimeKind.Local).AddTicks(5650), null, 30, 2 },
                    { 4, new DateTime(2024, 3, 11, 19, 22, 5, 550, DateTimeKind.Local).AddTicks(5724), null, 40, 2 },
                    { 5, new DateTime(2024, 3, 11, 19, 22, 5, 550, DateTimeKind.Local).AddTicks(5764), null, 50, 2 },
                    { 6, new DateTime(2024, 3, 11, 19, 22, 5, 550, DateTimeKind.Local).AddTicks(5802), null, 60, 2 },
                    { 7, new DateTime(2024, 3, 11, 19, 22, 5, 550, DateTimeKind.Local).AddTicks(5877), null, 70, 2 },
                    { 8, new DateTime(2024, 3, 11, 19, 22, 5, 550, DateTimeKind.Local).AddTicks(5913), null, 80, 2 },
                    { 9, new DateTime(2024, 3, 11, 19, 22, 5, 550, DateTimeKind.Local).AddTicks(5936), null, 90, 2 },
                    { 10, new DateTime(2024, 3, 11, 19, 22, 5, 550, DateTimeKind.Local).AddTicks(5993), null, 100, 2 },
                    { 11, new DateTime(2024, 3, 11, 19, 22, 5, 550, DateTimeKind.Local).AddTicks(6016), null, 110, 2 },
                    { 12, new DateTime(2024, 3, 11, 19, 22, 5, 550, DateTimeKind.Local).AddTicks(6039), null, 120, 2 },
                    { 13, new DateTime(2024, 3, 11, 19, 22, 5, 550, DateTimeKind.Local).AddTicks(6062), null, 130, 2 },
                    { 14, new DateTime(2024, 3, 11, 19, 22, 5, 550, DateTimeKind.Local).AddTicks(6084), null, 140, 2 },
                    { 15, new DateTime(2024, 3, 11, 19, 22, 5, 550, DateTimeKind.Local).AddTicks(6105), null, 150, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "OrderHeaderID",
                value: 1);

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "OrderHeaderID", "ProductID", "Quantity" },
                values: new object[,]
                {
                    { 4, 2, 1, 2 },
                    { 5, 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Barcode", "ProductDescription", "ProductName", "ProductPrice", "ProductTypeID", "Slika", "StateMachine" },
                values: new object[,]
                {
                    { 3, "123456789003", "Colgate Total pasta za zube pruža dugotrajnu sveobuhvatnu zaštitu vaših zuba i desni. Smanjuje plak, jača zubnu gleđ i pruža svež dah.", "Colgate Total", 7, 2, null, "Active" },
                    { 4, "123456789004", "Električna četkica za zube Oral-B Pro 1000 pruža učinkovito čišćenje zuba i desni. Ima senzor pritiska koji vas upozorava ako previše pritiskate prilikom četkanja.", "Oral-B Pro 1000", 40, 3, null, "Active" },
                    { 5, "123456789005", "Sensodyne Pronamel pasta za zube štiti od erozije zubne gleđi i pomaže u smanjenju osetljivosti zuba na toplo, hladno, slatko ili kiselo.", "Sensodyne Pronamel", 8, 2, null, "Active" },
                    { 6, "123456789006", "Crest 3D White pasta za beljenje zuba uklanja mrlje s površine zuba i pruža sjajno beli osmeh. Formulirana s aktivnim sastojcima za izbeljivanje.", "Crest 3D White", 12, 1, null, "Active" },
                    { 7, "123456789007", "Listerine Total Care rastvor za ispiranje usta pruža sveobuhvatnu zaštitu od gingivitisa, kamenca, lošeg daha i drugih problema s ustima.", "Listerine Total Care", 15, 4, null, "Active" },
                    { 8, "123456789008", "Waterpik Aquarius je električni uređaj za oralno ispiranje koji pomaže u uklanjanju zubnog plaka i poboljšava zdravlje desni. Idealan za korišćenje kod kuće.", "Waterpik Aquarius", 50, 3, null, "Active" },
                    { 9, "123456789009", "Arm & Hammer Advance White pasta za zube sadrži posebne sastojke koji pomažu u beljenju zuba i pružaju dugotrajan osećaj svežine.", "Arm & Hammer Advance White", 9, 2, null, "Active" },
                    { 10, "123456789010", "Philips Sonicare DiamondClean je električna četkica za zube koja nudi naprednu tehnologiju čišćenja i pomaže u uklanjanju do 10 puta više plaka u poređenju s ručnim četkama.", "Philips Sonicare DiamondClean", 120, 3, null, "Active" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "OrderHeaderID", "ProductID", "Quantity" },
                values: new object[,]
                {
                    { 3, 1, 3, 2 },
                    { 6, 2, 3, 2 },
                    { 7, 3, 1, 2 },
                    { 8, 3, 2, 2 },
                    { 9, 3, 3, 2 },
                    { 10, 4, 1, 2 },
                    { 11, 4, 2, 2 },
                    { 12, 4, 3, 2 },
                    { 13, 5, 1, 2 },
                    { 14, 5, 2, 2 },
                    { 15, 5, 3, 2 },
                    { 16, 6, 1, 2 },
                    { 17, 6, 2, 2 },
                    { 18, 6, 3, 2 },
                    { 19, 7, 1, 2 },
                    { 20, 7, 2, 2 },
                    { 21, 7, 3, 2 },
                    { 22, 8, 1, 2 },
                    { 23, 8, 2, 2 },
                    { 24, 8, 3, 2 },
                    { 25, 9, 1, 2 },
                    { 26, 9, 2, 2 },
                    { 27, 9, 3, 2 },
                    { 28, 10, 1, 2 },
                    { 29, 10, 2, 2 },
                    { 30, 10, 3, 2 },
                    { 31, 11, 1, 2 },
                    { 32, 11, 2, 2 },
                    { 33, 11, 3, 2 },
                    { 34, 12, 1, 2 },
                    { 35, 12, 2, 2 },
                    { 36, 12, 3, 2 },
                    { 37, 13, 1, 2 },
                    { 38, 13, 2, 2 },
                    { 39, 13, 3, 2 },
                    { 40, 14, 1, 2 },
                    { 41, 14, 2, 2 },
                    { 42, 14, 3, 2 },
                    { 43, 15, 1, 2 },
                    { 44, 15, 2, 2 },
                    { 45, 15, 3, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OrderHeader",
                keyColumn: "OrderHeaderID",
                keyValue: 15);

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
                columns: new[] { "OrderDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 10, 21, 11, 59, 562, DateTimeKind.Local).AddTicks(4686), "closed" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "OrderHeaderID",
                value: 2);
        }
    }
}
