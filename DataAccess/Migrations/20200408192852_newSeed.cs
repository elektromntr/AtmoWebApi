using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class newSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "Archived", "Content", "CreationDate", "EditDate" },
                values: new object[,]
                {
                    { 69, false, "69", new DateTime(2020, 4, 8, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(9140), null },
                    { 28, true, "Test archived Ticket number 13", new DateTime(2019, 3, 8, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8412), null },
                    { 13, false, "Test Ticket number 13", new DateTime(2020, 3, 26, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8406), null },
                    { 27, true, "Test archived Ticket number 12", new DateTime(2019, 4, 8, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8400), null },
                    { 12, false, "Test Ticket number 12", new DateTime(2020, 3, 27, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8395), null },
                    { 26, true, "Test archived Ticket number 11", new DateTime(2019, 5, 8, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8389), null },
                    { 11, false, "Test Ticket number 11", new DateTime(2020, 3, 28, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8383), null },
                    { 25, true, "Test archived Ticket number 10", new DateTime(2019, 6, 8, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8377), null },
                    { 10, false, "Test Ticket number 10", new DateTime(2020, 3, 29, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8371), null },
                    { 24, true, "Test archived Ticket number 9", new DateTime(2019, 7, 8, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8365), null },
                    { 9, false, "Test Ticket number 9", new DateTime(2020, 3, 30, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8359), null },
                    { 23, true, "Test archived Ticket number 8", new DateTime(2019, 8, 8, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8353), null },
                    { 8, false, "Test Ticket number 8", new DateTime(2020, 3, 31, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8347), null },
                    { 14, false, "Test Ticket number 14", new DateTime(2020, 3, 25, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8418), null },
                    { 22, true, "Test archived Ticket number 7", new DateTime(2019, 9, 8, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8341), null },
                    { 21, true, "Test archived Ticket number 6", new DateTime(2019, 10, 8, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8330), null },
                    { 6, false, "Test Ticket number 6", new DateTime(2020, 4, 2, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8324), null },
                    { 20, true, "Test archived Ticket number 5", new DateTime(2019, 11, 8, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8318), null },
                    { 5, false, "Test Ticket number 5", new DateTime(2020, 4, 3, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8312), null },
                    { 19, true, "Test archived Ticket number 4", new DateTime(2019, 12, 8, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8305), null },
                    { 4, false, "Test Ticket number 4", new DateTime(2020, 4, 4, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8299), null },
                    { 18, true, "Test archived Ticket number 3", new DateTime(2020, 1, 8, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8293), null },
                    { 3, false, "Test Ticket number 3", new DateTime(2020, 4, 5, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8280), null },
                    { 17, true, "Test archived Ticket number 2", new DateTime(2020, 2, 8, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8273), null },
                    { 2, false, "Test Ticket number 2", new DateTime(2020, 4, 6, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8266), null },
                    { 16, true, "Test archived Ticket number 1", new DateTime(2020, 3, 8, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8217), null },
                    { 1, false, "Test Ticket number 1", new DateTime(2020, 4, 7, 21, 28, 51, 873, DateTimeKind.Local).AddTicks(6950), null },
                    { 7, false, "Test Ticket number 7", new DateTime(2020, 4, 1, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8336), null },
                    { 29, true, "Test archived Ticket number 14", new DateTime(2019, 2, 8, 21, 28, 51, 876, DateTimeKind.Local).AddTicks(8423), null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 69);
        }
    }
}
