using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionProject.Migrations
{
    public partial class tabletask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "891f075c-0b5e-4194-a203-64076b6a95b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2a3e034-d57c-4a83-804d-c3218ede534c");

            migrationBuilder.RenameColumn(
                name: "duedate",
                table: "Tasks",
                newName: "DueDate");

            migrationBuilder.RenameColumn(
                name: "Nametask",
                table: "Tasks",
                newName: "NameTask");

            migrationBuilder.AddColumn<string>(
                name: "Group",
                table: "TeamMembers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Group",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1",
                column: "ConcurrencyStamp",
                value: "b78aa6c3-8d86-4a70-a458-e16421fa029e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4231f604-6214-41b0-b838-ab30ed90b6e7", "58be17d1-fc27-4941-98cb-816fb6e03228", "Client", "CLIENT" },
                    { "1e82fd88-4d1a-481c-915c-0211906d000b", "53685688-6fb4-42e5-bcbb-440dcbe2c718", "TeamMember", "TEAMMEMBER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "71a60bd0-502c-4d96-b31a-c7a7d7d2e833", "AQAAAAEAACcQAAAAEBm6PKp8K7X8BiZ8pNUGmRuJsIPtPknu1LnkfYC7NFCzTUGYXVyqM9ZICBLPALm0eg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e82fd88-4d1a-481c-915c-0211906d000b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4231f604-6214-41b0-b838-ab30ed90b6e7");

            migrationBuilder.DropColumn(
                name: "Group",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "Group",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "NameTask",
                table: "Tasks",
                newName: "Nametask");

            migrationBuilder.RenameColumn(
                name: "DueDate",
                table: "Tasks",
                newName: "duedate");

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
        }
    }
}
