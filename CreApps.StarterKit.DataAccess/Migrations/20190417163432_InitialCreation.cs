using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CreApps.StarterKit.DataAccess.Migrations
{
    public partial class InitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Priority",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    PriorityName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priority", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    StatusName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TicketType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    TicketTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    TypeId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    PriorityId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_Priority_PriorityId",
                        column: x => x.PriorityId,
                        principalTable: "Priority",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_TicketType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TicketType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Priority",
                columns: new[] { "Id", "CreatedOn", "PriorityName", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(3275), "Critical", new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(3280) },
                    { 2, new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(4339), "Urgent", new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(4344) },
                    { 3, new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(4351), "Medium", new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(4352) },
                    { 4, new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(4353), "Low", new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(4354) }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "CreatedOn", "StatusName", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(5718), "Pending", new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(5721) },
                    { 2, new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(6593), "In progress", new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(6595) },
                    { 3, new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(6601), "Resolved", new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(6602) },
                    { 4, new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(6603), "Closed", new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(6604) },
                    { 5, new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(6605), "Discarted", new DateTime(2019, 4, 17, 11, 34, 32, 36, DateTimeKind.Local).AddTicks(6606) }
                });

            migrationBuilder.InsertData(
                table: "TicketType",
                columns: new[] { "Id", "CreatedOn", "TicketTypeName", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 4, 17, 11, 34, 32, 32, DateTimeKind.Local).AddTicks(1224), "Problem", new DateTime(2019, 4, 17, 11, 34, 32, 33, DateTimeKind.Local).AddTicks(4062) },
                    { 2, new DateTime(2019, 4, 17, 11, 34, 32, 33, DateTimeKind.Local).AddTicks(7043), "Incident", new DateTime(2019, 4, 17, 11, 34, 32, 33, DateTimeKind.Local).AddTicks(7051) },
                    { 3, new DateTime(2019, 4, 17, 11, 34, 32, 33, DateTimeKind.Local).AddTicks(7060), "New Requirement", new DateTime(2019, 4, 17, 11, 34, 32, 33, DateTimeKind.Local).AddTicks(7061) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_PriorityId",
                table: "Ticket",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_StatusId",
                table: "Ticket",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_TypeId",
                table: "Ticket",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Priority");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "TicketType");
        }
    }
}
