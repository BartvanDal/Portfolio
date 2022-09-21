using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Data.Migrations
{
    public partial class addedmoreseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Goudkoorts //als dat werkt" });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Description", "Name", "StartedAt" },
                values: new object[] { 2, null, "Portfolio", new DateTime(2022, 9, 21, 9, 51, 43, 252, DateTimeKind.Local).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "YearStarted",
                value: 2017);

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name", "YearStarted" },
                values: new object[] { 2, "HTML5", 2016 });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name", "YearStarted" },
                values: new object[] { 3, "CSS3", 2016 });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name", "YearStarted" },
                values: new object[] { 4, ".Net", 2017 });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name", "YearStarted" },
                values: new object[] { 5, ".Net Core", 2019 });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name", "YearStarted" },
                values: new object[] { 6, "Angular", 2021 });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name", "YearStarted" },
                values: new object[] { 7, "Blazor", 2022 });

            migrationBuilder.InsertData(
                table: "ExperienceTag",
                columns: new[] { "ExperiencesId", "TagsId" },
                values: new object[] { 1, 4 });

            migrationBuilder.InsertData(
                table: "ExperienceTag",
                columns: new[] { "ExperiencesId", "TagsId" },
                values: new object[] { 1, 5 });

            migrationBuilder.InsertData(
                table: "ExperienceTag",
                columns: new[] { "ExperiencesId", "TagsId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "ExperienceTag",
                columns: new[] { "ExperiencesId", "TagsId" },
                values: new object[] { 2, 5 });

            migrationBuilder.InsertData(
                table: "ExperienceTag",
                columns: new[] { "ExperiencesId", "TagsId" },
                values: new object[] { 2, 7 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExperienceTag",
                keyColumns: new[] { "ExperiencesId", "TagsId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ExperienceTag",
                keyColumns: new[] { "ExperiencesId", "TagsId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ExperienceTag",
                keyColumns: new[] { "ExperiencesId", "TagsId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ExperienceTag",
                keyColumns: new[] { "ExperiencesId", "TagsId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "ExperienceTag",
                keyColumns: new[] { "ExperiencesId", "TagsId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { null, "AniMedic" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "YearStarted",
                value: 2018);
        }
    }
}
