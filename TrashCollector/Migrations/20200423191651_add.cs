using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "578672c8-961f-465e-a7f1-766f7abffd9b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "834e72fa-5280-4d9b-9f15-06520047a439");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bfd25a86-c81d-4551-a875-b679a7633ae7", "c95177f9-c3e4-4507-8385-1a3aef8dcbdf", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5d904c32-89a8-4753-9ca5-91fab99f2a9b", "55da3b1e-ab6c-429f-89f9-4df321c31982", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d904c32-89a8-4753-9ca5-91fab99f2a9b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfd25a86-c81d-4551-a875-b679a7633ae7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "834e72fa-5280-4d9b-9f15-06520047a439", "d04113df-5c3a-4bd1-a2ac-612a2e63899a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "578672c8-961f-465e-a7f1-766f7abffd9b", "61086ac7-4d8c-41b4-a628-7d52e3a0422f", "Employee", "EMPLOYEE" });
        }
    }
}
