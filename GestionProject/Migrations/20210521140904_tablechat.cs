using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionProject.Migrations
{
    public partial class tablechat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60c7b74a-bd8e-475f-ac53-8a397c6b8d39");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b535addc-4fd8-44cc-b95e-579f38c4ab67");

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    when = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProjectId = table.Column<int>(type: "int" , nullable: true),
                    
                    DocumentId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FileType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DataFiles = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    TeamMemberId = table.Column<int>(type: "int", nullable: true),
                 
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Files_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Files_Projects_projectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Files_TeamMembers_teamMemberId",
                        column: x => x.TeamMemberId,
                        principalTable: "TeamMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1",
                column: "ConcurrencyStamp",
                value: "e86af86c-3af6-4fbd-839e-18ce03fe319f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "28982a96-50da-4ec9-9f0d-a9745f7f53ac", "dc7b5224-ee55-4742-b1b7-6542c94cb520", "Client", "CLIENT" },
                    { "f96a6902-b74d-4cde-b4db-a16bccbe71ea", "355867d9-9eb2-432f-a940-908c6c2115c3", "TeamMember", "TEAMMEMBER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ab209cf-7d34-4f0c-8432-40e99782b33e", "AQAAAAEAACcQAAAAELLQSXLMd1b6q5PtmmcQtcDvH9DZRzYl9hkDYcV/KSsWu9ZUw+EJ5QpvoVHQGoa8JQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Files_AppUserId",
                table: "Files",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_projectId",
                table: "Files",
                column: "projectId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_teamMemberId",
                table: "Files",
                column: "teamMemberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28982a96-50da-4ec9-9f0d-a9745f7f53ac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f96a6902-b74d-4cde-b4db-a16bccbe71ea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1",
                column: "ConcurrencyStamp",
                value: "734868bf-d27f-414b-800d-620e46cbb26b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "60c7b74a-bd8e-475f-ac53-8a397c6b8d39", "42e4430f-36f6-4eca-8850-93cf57d9c94c", "Client", "CLIENT" },
                    { "b535addc-4fd8-44cc-b95e-579f38c4ab67", "f61a419c-628d-4c26-940a-fedb61029c33", "TeamMember", "TEAMMEMBER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7ea83c45-6251-4cad-ba09-804774181cf9", "AQAAAAEAACcQAAAAEAuX4c99MyrSXd5eqHcRkfgGwirORXEeil5siObCTTgWBskOlAW0vnhkTcHoHXrElw==" });
        }
    }
}
