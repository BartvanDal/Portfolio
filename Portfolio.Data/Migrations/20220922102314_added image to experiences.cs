using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Data.Migrations
{
    public partial class addedimagetoexperiences : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Experiences",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageName",
                value: "c1bf47f0ecce9864a6d5e4651ef11782.jpg");

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartedAt",
                value: new DateTime(2022, 9, 22, 12, 23, 14, 306, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartedAt",
                value: new DateTime(2022, 9, 22, 12, 23, 14, 306, DateTimeKind.Local).AddTicks(3282));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Experiences");

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartedAt",
                value: new DateTime(2022, 9, 21, 11, 32, 55, 456, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartedAt",
                value: new DateTime(2022, 9, 21, 11, 32, 55, 456, DateTimeKind.Local).AddTicks(3971));
        }
    }
}
