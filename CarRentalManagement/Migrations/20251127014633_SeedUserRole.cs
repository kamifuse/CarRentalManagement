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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "ca5ec745-c92b-40a8-addf-c9953ad0aef6", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEOsCPpCkCjj1Gmk3tHx5WBqMeWrk4HzODeWcCMbu6GualPZL6wEDxoSiu+x9CTN6+w==", null, false, "cd52e74f-7b38-425f-8862-1d96b0027dd3", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 46, 33, 154, DateTimeKind.Local).AddTicks(5505), new DateTime(2025, 11, 27, 9, 46, 33, 154, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 46, 33, 154, DateTimeKind.Local).AddTicks(5521), new DateTime(2025, 11, 27, 9, 46, 33, 154, DateTimeKind.Local).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 46, 33, 154, DateTimeKind.Local).AddTicks(5766), new DateTime(2025, 11, 27, 9, 46, 33, 154, DateTimeKind.Local).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 46, 33, 154, DateTimeKind.Local).AddTicks(5770), new DateTime(2025, 11, 27, 9, 46, 33, 154, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 46, 33, 154, DateTimeKind.Local).AddTicks(5900), new DateTime(2025, 11, 27, 9, 46, 33, 154, DateTimeKind.Local).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 46, 33, 154, DateTimeKind.Local).AddTicks(5903), new DateTime(2025, 11, 27, 9, 46, 33, 154, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 46, 33, 154, DateTimeKind.Local).AddTicks(5906), new DateTime(2025, 11, 27, 9, 46, 33, 154, DateTimeKind.Local).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 46, 33, 154, DateTimeKind.Local).AddTicks(5909), new DateTime(2025, 11, 27, 9, 46, 33, 154, DateTimeKind.Local).AddTicks(5910) });

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
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 34, 17, 219, DateTimeKind.Local).AddTicks(9319), new DateTime(2025, 11, 27, 9, 34, 17, 219, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 34, 17, 219, DateTimeKind.Local).AddTicks(9336), new DateTime(2025, 11, 27, 9, 34, 17, 219, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 34, 17, 219, DateTimeKind.Local).AddTicks(9532), new DateTime(2025, 11, 27, 9, 34, 17, 219, DateTimeKind.Local).AddTicks(9533) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 34, 17, 219, DateTimeKind.Local).AddTicks(9534), new DateTime(2025, 11, 27, 9, 34, 17, 219, DateTimeKind.Local).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 34, 17, 219, DateTimeKind.Local).AddTicks(9619), new DateTime(2025, 11, 27, 9, 34, 17, 219, DateTimeKind.Local).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 34, 17, 219, DateTimeKind.Local).AddTicks(9621), new DateTime(2025, 11, 27, 9, 34, 17, 219, DateTimeKind.Local).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 34, 17, 219, DateTimeKind.Local).AddTicks(9623), new DateTime(2025, 11, 27, 9, 34, 17, 219, DateTimeKind.Local).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 34, 17, 219, DateTimeKind.Local).AddTicks(9625), new DateTime(2025, 11, 27, 9, 34, 17, 219, DateTimeKind.Local).AddTicks(9626) });
        }
    }
}
