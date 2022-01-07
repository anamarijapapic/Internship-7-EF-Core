using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StackInternship.Data.Migrations
{
    public partial class AddSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DeactivationExpirationDate", "FirstName", "LabeledTrusted", "LastName", "Password", "RegistrationDate", "ReputationPoints", "Role", "Username" },
                values: new object[] { 1, null, "Ana", false, "Anic", "123", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "aanic" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DeactivationExpirationDate", "FirstName", "LabeledTrusted", "LastName", "Password", "RegistrationDate", "ReputationPoints", "Role", "Username" },
                values: new object[] { 2, null, "Duje", true, "Dujic", "456", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 100000, 0, "ddujic" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DeactivationExpirationDate", "FirstName", "LabeledTrusted", "LastName", "Password", "RegistrationDate", "ReputationPoints", "Role", "Username" },
                values: new object[] { 3, null, "Tonci", false, "Toncic", "789", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, 1, "ttoncic" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Category", "Content", "DateOfPosting", "UserId" },
                values: new object[] { 1, 0, "1. resurs", new DateTime(2022, 1, 7, 19, 45, 4, 257, DateTimeKind.Local).AddTicks(4977), 1 });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Category", "Content", "DateOfPosting", "UserId" },
                values: new object[] { 2, 0, "2. resurs", new DateTime(2022, 1, 7, 19, 45, 4, 260, DateTimeKind.Local).AddTicks(3505), 2 });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Category", "Content", "DateOfPosting", "UserId" },
                values: new object[] { 3, 4, "3. resurs", new DateTime(2022, 1, 7, 19, 45, 4, 260, DateTimeKind.Local).AddTicks(3548), 3 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "DateOfPosting", "ParentId", "ResourceId", "UserId" },
                values: new object[] { 1, "1. komentar", new DateTime(2022, 1, 7, 19, 45, 4, 260, DateTimeKind.Local).AddTicks(5496), null, 1, 1 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "DateOfPosting", "ParentId", "ResourceId", "UserId" },
                values: new object[] { 2, "2. komentar", new DateTime(2022, 1, 7, 19, 45, 4, 260, DateTimeKind.Local).AddTicks(6786), null, 2, 2 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "DateOfPosting", "ParentId", "ResourceId", "UserId" },
                values: new object[] { 3, "3. komentar", new DateTime(2022, 1, 7, 19, 45, 4, 260, DateTimeKind.Local).AddTicks(6800), 1, 2, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
