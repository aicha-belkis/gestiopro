using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionProject.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4abedd56-1193-4013-b680-371343c1a39c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd0e49ca-2a43-42b0-b705-83da92f37ffa");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60c7b74a-bd8e-475f-ac53-8a397c6b8d39");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b535addc-4fd8-44cc-b95e-579f38c4ab67");

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
        }
    }
}
