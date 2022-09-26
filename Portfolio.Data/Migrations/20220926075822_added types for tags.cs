using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Data.Migrations
{
    public partial class addedtypesfortags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Tags",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "ExperienceTag",
                columns: new[] { "ExperiencesId", "TagsId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "ExperienceTag",
                columns: new[] { "ExperiencesId", "TagsId" },
                values: new object[] { 1, 3 });

            migrationBuilder.InsertData(
                table: "ExperienceTag",
                columns: new[] { "ExperiencesId", "TagsId" },
                values: new object[] { 1, 6 });

            migrationBuilder.InsertData(
                table: "ExperienceTag",
                columns: new[] { "ExperiencesId", "TagsId" },
                values: new object[] { 1, 7 });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name", "StartedAt" },
                values: new object[] { "Binnen Sogeti heb ik een specialisatieopleiding gevolgd. Hier heb ik gewerkt aan de backend van een onboardingsapp voor nieuwe medewerkers. Het doel van de onboardingsapp is een takenlijst en algemene informatie tonen zodat nieuwe medewerkers weten wat van hen wordt verwacht en waar ze informatie kunnen vinden.\r\n\r\nIn dit project was ik verantwoordelijk voor het opzetten van een Restful API gemaakt in ASP .Net Core welke geconsumeerd werden door een React Native mobiele app en een Angular dashboard applicatie. Daarnaast heb ik gewerkt aan de frontend van het Angular dashboard.\r\n", "Basisopleiding Sogeti", new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Type", "YearStarted" },
                values: new object[] { "Typescript", 0, 2021 });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Type", "YearStarted" },
                values: new object[] { ".Net Framework", 1, 2017 });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "Type", "YearStarted" },
                values: new object[] { ".Net Core", 1, 2019 });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "Type", "YearStarted" },
                values: new object[] { "Angular", 1, 2021 });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name", "Type", "YearStarted" },
                values: new object[] { 8, "Blazor", 1, 2022 });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name", "Type", "YearStarted" },
                values: new object[] { 9, "ASP .Net Core", 1, 2019 });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name", "Type", "YearStarted" },
                values: new object[] { 10, "RESTful APIs", null, 2021 });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name", "Type", "YearStarted" },
                values: new object[] { 11, "Bootstrap", 1, 2017 });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name", "Type", "YearStarted" },
                values: new object[] { 12, "Visual Studio", 2, 2015 });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name", "Type", "YearStarted" },
                values: new object[] { 13, "Visual Studio Code", 2, 2017 });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name", "Type", "YearStarted" },
                values: new object[] { 14, "Nuget", 2, 2015 });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name", "Type", "YearStarted" },
                values: new object[] { 15, "Entity Framework", 2, 2019 });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name", "Type", "YearStarted" },
                values: new object[] { 16, "npm", 2, 2020 });

            migrationBuilder.InsertData(
                table: "ExperienceTag",
                columns: new[] { "ExperiencesId", "TagsId" },
                values: new object[] { 1, 9 });

            migrationBuilder.InsertData(
                table: "ExperienceTag",
                columns: new[] { "ExperiencesId", "TagsId" },
                values: new object[] { 1, 10 });

            migrationBuilder.InsertData(
                table: "ExperienceTag",
                columns: new[] { "ExperiencesId", "TagsId" },
                values: new object[] { 1, 11 });

            migrationBuilder.InsertData(
                table: "ExperienceTag",
                columns: new[] { "ExperiencesId", "TagsId" },
                values: new object[] { 1, 12 });

            migrationBuilder.InsertData(
                table: "ExperienceTag",
                columns: new[] { "ExperiencesId", "TagsId" },
                values: new object[] { 1, 13 });

            migrationBuilder.InsertData(
                table: "ExperienceTag",
                columns: new[] { "ExperiencesId", "TagsId" },
                values: new object[] { 1, 14 });

            migrationBuilder.InsertData(
                table: "ExperienceTag",
                columns: new[] { "ExperiencesId", "TagsId" },
                values: new object[] { 1, 15 });

            migrationBuilder.InsertData(
                table: "ExperienceTag",
                columns: new[] { "ExperiencesId", "TagsId" },
                values: new object[] { 1, 16 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExperienceTag",
                keyColumns: new[] { "ExperiencesId", "TagsId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ExperienceTag",
                keyColumns: new[] { "ExperiencesId", "TagsId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ExperienceTag",
                keyColumns: new[] { "ExperiencesId", "TagsId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "ExperienceTag",
                keyColumns: new[] { "ExperiencesId", "TagsId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "ExperienceTag",
                keyColumns: new[] { "ExperiencesId", "TagsId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "ExperienceTag",
                keyColumns: new[] { "ExperiencesId", "TagsId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "ExperienceTag",
                keyColumns: new[] { "ExperiencesId", "TagsId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "ExperienceTag",
                keyColumns: new[] { "ExperiencesId", "TagsId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "ExperienceTag",
                keyColumns: new[] { "ExperiencesId", "TagsId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "ExperienceTag",
                keyColumns: new[] { "ExperiencesId", "TagsId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "ExperienceTag",
                keyColumns: new[] { "ExperiencesId", "TagsId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "ExperienceTag",
                keyColumns: new[] { "ExperiencesId", "TagsId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Tags");

            migrationBuilder.InsertData(
                table: "ExperienceTag",
                columns: new[] { "ExperiencesId", "TagsId" },
                values: new object[] { 1, 5 });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name", "StartedAt" },
                values: new object[] { "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Goudkoorts", new DateTime(2018, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Description", "ImageName", "Name", "StartedAt" },
                values: new object[] { 2, null, null, "Portfolio", new DateTime(2022, 9, 22, 12, 23, 14, 306, DateTimeKind.Local).AddTicks(3280) });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Description", "ImageName", "Name", "StartedAt" },
                values: new object[] { 3, null, null, "Basisopleiding Sogeti", new DateTime(2022, 9, 22, 12, 23, 14, 306, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "YearStarted" },
                values: new object[] { ".Net", 2017 });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "YearStarted" },
                values: new object[] { ".Net Core", 2019 });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "YearStarted" },
                values: new object[] { "Angular", 2021 });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "YearStarted" },
                values: new object[] { "Blazor", 2022 });

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
    }
}
