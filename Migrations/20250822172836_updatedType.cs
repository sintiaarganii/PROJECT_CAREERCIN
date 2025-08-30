using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROJECT_CAREERCIN.Migrations
{
    /// <inheritdoc />
    public partial class updatedType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NoHP",
                table: "Lamarans",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 8, 23, 0, 28, 34, 53, DateTimeKind.Local).AddTicks(7969), "$2a$11$/P3wqqpcxV6lTCw7CICaleE000NlIR1d1FL8E20gKq/dbt.wLgHyC" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NoHP",
                table: "Lamarans",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 8, 21, 14, 49, 31, 524, DateTimeKind.Local).AddTicks(4112), "$2a$11$a8KUh9G7QVOVU1kjb/M2WOmZyXA4MQZOwz4BVQhMYioWx10g9Xpfi" });
        }
    }
}
