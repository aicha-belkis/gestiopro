using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionProject.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c8fdf12-7d9b-4681-9bdb-a8bf2d3a6ead");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e928b375-b086-45a9-abf2-f0fac9a6f66f");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Projects",
                newName: "Teams");

            migrationBuilder.AddColumn<string>(
                name: "Group",
                table: "TeamMembers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "TeamMembers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientName",
                table: "TeamMemberProject",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "TeamMemberProject",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "TeamMemberProject",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProjectName",
                table: "TeamMemberProject",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaskID",
                table: "TeamMemberProject",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TasksId",
                table: "TeamMemberProject",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MangerId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProjectManager",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectName",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ClientName",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManagerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Managers_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameTask = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MangerId = table.Column<int>(type: "int", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tasks_Managers_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Managers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tasks_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1",
                column: "ConcurrencyStamp",
                value: "0741d590-44e8-4c29-adc3-c07408ccbf6a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bd0e49ca-2a43-42b0-b705-83da92f37ffa", "67f6c45f-c6eb-42d5-a346-cd5c030be29d", "Client", "CLIENT" },
                    { "4abedd56-1193-4013-b680-371343c1a39c", "e52e3afa-d7cc-4dc2-84f8-4a9adb5c3d92", "TeamMember", "TEAMMEMBER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "78d65f52-0aeb-418f-8c1c-25996a2f59fd", "AQAAAAEAACcQAAAAEPWMdLHtwAEoyUiXbwbeLp9WhWJnAgNIlvQSpWCuhHkd5ChKlHcwOOwjnFLxYczj8g==" });

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_ManagerId",
                table: "TeamMembers",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMemberProject_ManagerId",
                table: "TeamMemberProject",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMemberProject_TasksId",
                table: "TeamMemberProject",
                column: "TasksId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ManagerId",
                table: "Projects",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Managers_AppUserId",
                table: "Managers",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_AppUserId",
                table: "Tasks",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ManagerId",
                table: "Tasks",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ProjectId",
                table: "Tasks",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Managers_ManagerId",
                table: "Projects",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMemberProject_Managers_ManagerId",
                table: "TeamMemberProject",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMemberProject_Tasks_TasksId",
                table: "TeamMemberProject",
                column: "TasksId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMembers_Managers_ManagerId",
                table: "TeamMembers",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Managers_ManagerId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamMemberProject_Managers_ManagerId",
                table: "TeamMemberProject");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamMemberProject_Tasks_TasksId",
                table: "TeamMemberProject");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamMembers_Managers_ManagerId",
                table: "TeamMembers");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropIndex(
                name: "IX_TeamMembers_ManagerId",
                table: "TeamMembers");

            migrationBuilder.DropIndex(
                name: "IX_TeamMemberProject_ManagerId",
                table: "TeamMemberProject");

            migrationBuilder.DropIndex(
                name: "IX_TeamMemberProject_TasksId",
                table: "TeamMemberProject");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ManagerId",
                table: "Projects");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4abedd56-1193-4013-b680-371343c1a39c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd0e49ca-2a43-42b0-b705-83da92f37ffa");

            migrationBuilder.DropColumn(
                name: "Group",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "ClientName",
                table: "TeamMemberProject");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "TeamMemberProject");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "TeamMemberProject");

            migrationBuilder.DropColumn(
                name: "ProjectName",
                table: "TeamMemberProject");

            migrationBuilder.DropColumn(
                name: "TaskID",
                table: "TeamMemberProject");

            migrationBuilder.DropColumn(
                name: "TasksId",
                table: "TeamMemberProject");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "MangerId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectManager",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectName",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ClientName",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "Teams",
                table: "Projects",
                newName: "Name");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1",
                column: "ConcurrencyStamp",
                value: "486f0f92-8ce6-4d3d-9a63-c3a2f4620c33");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1c8fdf12-7d9b-4681-9bdb-a8bf2d3a6ead", "af0b837a-bcc4-4c13-ae5e-475d03f4aa00", "Client", "CLIENT" },
                    { "e928b375-b086-45a9-abf2-f0fac9a6f66f", "2cd9a7b2-7b04-4303-9f09-679b7b0f25d2", "TeamMember", "TEAMMEMBER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ff2a2acb-6197-4a48-97a4-193c1cbdfebe", "AQAAAAEAACcQAAAAEDfSNFSZYDEK0cXWxMFB2SF8wpW9k7OCOLtOC+4FoYS5oa2BPuVh1Ga+oAAaKEOcxw==" });
        }
    }
}
