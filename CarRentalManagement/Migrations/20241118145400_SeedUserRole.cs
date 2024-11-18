using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "edc35895-7e58-4a6b-aba9-23d233c335c3", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAENvMpRyf5WTakvcJi8CVg3JN9t9/9pf/e+L8EeJC4oPE10h1HrsZWy2aRs+thKX2sA==", null, false, "8b35df15-bb64-447d-9ba1-bd0ff647eb38", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 22, 53, 58, 743, DateTimeKind.Local).AddTicks(6173), new DateTime(2024, 11, 18, 22, 53, 58, 743, DateTimeKind.Local).AddTicks(6185) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 22, 53, 58, 743, DateTimeKind.Local).AddTicks(6189), new DateTime(2024, 11, 18, 22, 53, 58, 743, DateTimeKind.Local).AddTicks(6190) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 22, 53, 58, 743, DateTimeKind.Local).AddTicks(6502), new DateTime(2024, 11, 18, 22, 53, 58, 743, DateTimeKind.Local).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 22, 53, 58, 743, DateTimeKind.Local).AddTicks(6506), new DateTime(2024, 11, 18, 22, 53, 58, 743, DateTimeKind.Local).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 22, 53, 58, 743, DateTimeKind.Local).AddTicks(6737), new DateTime(2024, 11, 18, 22, 53, 58, 743, DateTimeKind.Local).AddTicks(6738) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 22, 53, 58, 743, DateTimeKind.Local).AddTicks(6741), new DateTime(2024, 11, 18, 22, 53, 58, 743, DateTimeKind.Local).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 22, 53, 58, 743, DateTimeKind.Local).AddTicks(6744), new DateTime(2024, 11, 18, 22, 53, 58, 743, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 22, 53, 58, 743, DateTimeKind.Local).AddTicks(6747), new DateTime(2024, 11, 18, 22, 53, 58, 743, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 33, 11, 252, DateTimeKind.Local).AddTicks(1165), new DateTime(2024, 11, 18, 17, 33, 11, 252, DateTimeKind.Local).AddTicks(1178) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 33, 11, 252, DateTimeKind.Local).AddTicks(1180), new DateTime(2024, 11, 18, 17, 33, 11, 252, DateTimeKind.Local).AddTicks(1180) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 33, 11, 252, DateTimeKind.Local).AddTicks(1392), new DateTime(2024, 11, 18, 17, 33, 11, 252, DateTimeKind.Local).AddTicks(1393) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 33, 11, 252, DateTimeKind.Local).AddTicks(1395), new DateTime(2024, 11, 18, 17, 33, 11, 252, DateTimeKind.Local).AddTicks(1395) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 33, 11, 252, DateTimeKind.Local).AddTicks(1478), new DateTime(2024, 11, 18, 17, 33, 11, 252, DateTimeKind.Local).AddTicks(1479) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 33, 11, 252, DateTimeKind.Local).AddTicks(1480), new DateTime(2024, 11, 18, 17, 33, 11, 252, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 33, 11, 252, DateTimeKind.Local).AddTicks(1482), new DateTime(2024, 11, 18, 17, 33, 11, 252, DateTimeKind.Local).AddTicks(1482) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 33, 11, 252, DateTimeKind.Local).AddTicks(1483), new DateTime(2024, 11, 18, 17, 33, 11, 252, DateTimeKind.Local).AddTicks(1484) });
        }
    }
}
