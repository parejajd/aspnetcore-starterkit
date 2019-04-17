using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CreApps.StarterKit.DataAccess.Migrations
{
    public partial class AddTicketSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(3526), new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(4296), new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(4305), new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(4307), new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(5329), new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(6021), new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(6027), new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(6029), new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(6031), new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(6031) });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "CreatedOn", "Description", "PriorityId", "StatusId", "Subject", "TypeId", "UpdatedOn" },
                values: new object[] { 1, new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(6970), "I need create a bd to save tickets", 1, 1, "Create DB", 1, new DateTime(2019, 4, 17, 11, 49, 1, 963, DateTimeKind.Local).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "TicketType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 49, 1, 960, DateTimeKind.Local).AddTicks(2227), new DateTime(2019, 4, 17, 11, 49, 1, 961, DateTimeKind.Local).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "TicketType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 49, 1, 961, DateTimeKind.Local).AddTicks(4315), new DateTime(2019, 4, 17, 11, 49, 1, 961, DateTimeKind.Local).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "TicketType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 49, 1, 961, DateTimeKind.Local).AddTicks(4331), new DateTime(2019, 4, 17, 11, 49, 1, 961, DateTimeKind.Local).AddTicks(4331) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(3275), new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(4339), new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(4351), new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(4353), new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(5718), new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(6593), new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(6595) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(6601), new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(6602) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(6603), new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(6605), new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "TicketType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 34, 32, 32, DateTimeKind.Local).AddTicks(1224), new DateTime(2019, 4, 17, 11, 34, 32, 33, DateTimeKind.Local).AddTicks(4062) });

            migrationBuilder.UpdateData(
                table: "TicketType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 34, 32, 33, DateTimeKind.Local).AddTicks(7043), new DateTime(2019, 4, 17, 11, 34, 32, 33, DateTimeKind.Local).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "TicketType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 4, 17, 11, 34, 32, 33, DateTimeKind.Local).AddTicks(7060), new DateTime(2019, 4, 17, 11, 34, 32, 33, DateTimeKind.Local).AddTicks(7061) });
        }
    }
}
