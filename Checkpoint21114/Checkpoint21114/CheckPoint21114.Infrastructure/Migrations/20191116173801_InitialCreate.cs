using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CheckPoint21114.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    ChoreTypeId = table.Column<int>(nullable: false),
                    ChoreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Chores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Deadline = table.Column<DateTime>(nullable: false),
                    AssignmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChoreTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChoreTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ChoreTypes",
                columns: new[] { "Id", "Title" },
                values: new object[] { 1, "Inside Chore" });

            migrationBuilder.InsertData(
                table: "ChoreTypes",
                columns: new[] { "Id", "Title" },
                values: new object[] { 2, "OutsideChore" });

            migrationBuilder.InsertData(
                table: "Chores",
                columns: new[] { "Id", "AssignmentId", "Deadline", "Description", "Title" },
                values: new object[] { 1, 0, new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "Wipe dust off of tables", "Dusting" });

            migrationBuilder.InsertData(
                table: "Chores",
                columns: new[] { "Id", "AssignmentId", "Deadline", "Description", "Title" },
                values: new object[] { 2, 0, new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), " Collect all garbage and take to dump", "Take out Garbage" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "Chores");

            migrationBuilder.DropTable(
                name: "ChoreTypes");
        }
    }
}
