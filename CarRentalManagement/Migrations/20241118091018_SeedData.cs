using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Customer_CustomerId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_CustomerId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "DataCreated",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "DateIn",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Vehicle",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "Vehicle",
                newName: "Year");

            migrationBuilder.RenameColumn(
                name: "DateOut",
                table: "Vehicle",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Vehicle",
                newName: "ModelId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Model",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Model",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Make",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Make",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customer",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Customer",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Colour",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Colour",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Booking",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Booking",
                newName: "DateCreated");

            migrationBuilder.AddColumn<int>(
                name: "ColourId",
                table: "Vehicle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MakeId",
                table: "Vehicle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataIn",
                table: "Booking",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataOut",
                table: "Booking",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 10, 18, 213, DateTimeKind.Local).AddTicks(9863), new DateTime(2024, 11, 18, 17, 10, 18, 213, DateTimeKind.Local).AddTicks(9875), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 10, 18, 213, DateTimeKind.Local).AddTicks(9877), new DateTime(2024, 11, 18, 17, 10, 18, 213, DateTimeKind.Local).AddTicks(9878), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 10, 18, 214, DateTimeKind.Local).AddTicks(120), new DateTime(2024, 11, 18, 17, 10, 18, 214, DateTimeKind.Local).AddTicks(121), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 10, 18, 214, DateTimeKind.Local).AddTicks(123), new DateTime(2024, 11, 18, 17, 10, 18, 214, DateTimeKind.Local).AddTicks(123), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 10, 18, 214, DateTimeKind.Local).AddTicks(33), new DateTime(2024, 11, 18, 17, 10, 18, 214, DateTimeKind.Local).AddTicks(34), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 10, 18, 214, DateTimeKind.Local).AddTicks(59), new DateTime(2024, 11, 18, 17, 10, 18, 214, DateTimeKind.Local).AddTicks(59), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 17, 10, 18, 214, DateTimeKind.Local).AddTicks(60), new DateTime(2024, 11, 18, 17, 10, 18, 214, DateTimeKind.Local).AddTicks(61), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 17, 10, 18, 214, DateTimeKind.Local).AddTicks(62), new DateTime(2024, 11, 18, 17, 10, 18, 214, DateTimeKind.Local).AddTicks(62), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "ColourId",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "LicensePlateNumber",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "MakeId",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "DataIn",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "DataOut",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Vehicle",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Vehicle",
                newName: "VehicleId");

            migrationBuilder.RenameColumn(
                name: "ModelId",
                table: "Vehicle",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Vehicle",
                newName: "DateOut");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Model",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Model",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Make",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Make",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Customer",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Customer",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Colour",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Colour",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Booking",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Booking",
                newName: "DataCreated");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCreated",
                table: "Vehicle",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateIn",
                table: "Vehicle",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Booking",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Booking_CustomerId",
                table: "Booking",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Customer_CustomerId",
                table: "Booking",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id");
        }
    }
}
