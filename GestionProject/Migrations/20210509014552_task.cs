using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionProject.Migrations
{
    public partial class task : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Projects_ProjectId",
                table: "Tasks");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d18e24d-0d06-4573-bc05-4d34ef3d63d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61585c5c-89b4-460b-b293-8d26c82aed48");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MangerId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1",
                column: "ConcurrencyStamp",
                value: "5695411d-e446-42fe-9f75-1bfddd9acb75");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "891f075c-0b5e-4194-a203-64076b6a95b8", "b9eea508-1c42-46d0-a3b6-04e9556797a6", "Client", "CLIENT" },
                    { "a2a3e034-d57c-4a83-804d-c3218ede534c", "099f30b4-8343-46d9-9c7f-b8b4b53a6268", "TeamMember", "TEAMMEMBER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e2fbe2eb-fb98-49d1-82a1-058d259a8e41", "AQAAAAEAACcQAAAAEPoaBMKvyp8dq3i1ZlNPy/OGRH+KyCZrBIjYse6Jvo4TRGKpBsCLO3rac3iyRampOA==" });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ManagerId",
                table: "Tasks",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Managers_ManagerId",
                table: "Tasks",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Projects_ProjectId",
                table: "Tasks",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Managers_ManagerId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Projects_ProjectId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_ManagerId",
                table: "Tasks");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "891f075c-0b5e-4194-a203-64076b6a95b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2a3e034-d57c-4a83-804d-c3218ede534c");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "MangerId",
                table: "Tasks");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Tasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1",
                column: "ConcurrencyStamp",
                value: "e98f4d80-9846-4b39-8e28-e20683b9ffbe");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5d18e24d-0d06-4573-bc05-4d34ef3d63d6", "45fdd27a-8f05-4588-98dc-69cbb909abba", "Client", "CLIENT" },
                    { "61585c5c-89b4-460b-b293-8d26c82aed48", "97ac481d-3517-407b-86a1-68d1d1ac3223", "TeamMember", "TEAMMEMBER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e476a8ba-5dad-4fe4-90c7-25d5eaf92e30", "AQAAAAEAACcQAAAAEH5iur/rzZVGuEnbigzt1m9Xk/hSRa9vKHvqj0iz9MVCGzwDidXGgjiI+8s4O4CvSw==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Projects_ProjectId",
                table: "Tasks",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
