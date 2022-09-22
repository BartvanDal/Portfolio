using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Data.Migrations
{
    public partial class addedbasisopleidingseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Goudkoorts");

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartedAt",
                value: new DateTime(2022, 9, 21, 11, 32, 55, 456, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Description", "Name", "StartedAt" },
                values: new object[] { 3, null, "Basisopleiding Sogeti", new DateTime(2022, 9, 21, 11, 32, 55, 456, DateTimeKind.Local).AddTicks(3971) });

            migrationBuilder.InsertData(
                table: "ExperienceTag",
                columns: new[] { "ExperiencesId", "TagsId" },
                values: new object[] { 3, 1 });

            migrationBuilder.InsertData(
                table: "ExperienceTag",
                columns: new[] { "ExperiencesId", "TagsId" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "ExperienceTag",
                columns: new[] { "ExperiencesId", "TagsId" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "ExperienceTag",
                columns: new[] { "ExperiencesId", "TagsId" },
                values: new object[] { 3, 5 });

            migrationBuilder.InsertData(
                table: "ExperienceTag",
                columns: new[] { "ExperiencesId", "TagsId" },
                values: new object[] { 3, 6 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExperienceTag",
                keyColumns: new[] { "ExperiencesId", "TagsId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ExperienceTag",
                keyColumns: new[] { "ExperiencesId", "TagsId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ExperienceTag",
                keyColumns: new[] { "ExperiencesId", "TagsId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ExperienceTag",
                keyColumns: new[] { "ExperiencesId", "TagsId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "ExperienceTag",
                keyColumns: new[] { "ExperiencesId", "TagsId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Goudkoorts //als dat werkt");

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartedAt",
                value: new DateTime(2022, 9, 21, 9, 51, 43, 252, DateTimeKind.Local).AddTicks(9700));
        }
    }
}
