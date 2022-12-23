using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoteApp.WebApi.Migrations
{
    public partial class InsertSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpireDate",
                schema: "dbo",
                table: "products",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "candidates",
                columns: new[] { "Id", "Description", "Image", "State" },
                values: new object[,]
                {
                    { new Guid("7a7ca13c-b54d-438b-ac64-bf0afb5f27ab"), "Игровая приставка последнего поколения", "https://webimg.secondhandapp.com/1.1/5ee090244cda6c0045831abe", 1 },
                    { new Guid("d02c6bfb-fce6-4dbf-94ec-57991d2dfa4f"), "Революционная платформа с множеством эксклюзивов", "https://frankfurt.apollo.olxcdn.com/v1/files/la9yesqjseih3-KZ/image;s=1280x960", 1 }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "DoB", "FName", "Image", "LName", "Login", "Password" },
                values: new object[,]
                {
                    { new Guid("7d42621c-3756-4a82-bf2b-69fcfca6e0f2"), new DateTime(1986, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Михаил", "https://media.istockphoto.com/id/918169872/photo/close-up-view-of-a-siberian-tiger.jpg?s=1024x1024&w=is&k=20&c=kDcPgGgEuSPt7_HNNlHqXEf4g86-ZIF5NLuobfm9NYg=", "Васильев", "rebusmv", "q2w3e4r5" },
                    { new Guid("cb06552d-4779-487d-a3ef-774406e705f9"), new DateTime(2000, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Семен", null, "Иванов", "ivanov", "123" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "products",
                columns: new[] { "Id", "Code", "ExpireDate", "Name", "Price" },
                values: new object[] { new Guid("7a7ca13c-b54d-438b-ac64-bf0afb5f27ab"), "1223654", null, "xBox", 1200m });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "products",
                columns: new[] { "Id", "Code", "ExpireDate", "Name", "Price" },
                values: new object[] { new Guid("d02c6bfb-fce6-4dbf-94ec-57991d2dfa4f"), "773332", null, "PS5", 2000m });

            migrationBuilder.InsertData(
                table: "votes",
                columns: new[] { "CandidateId", "UserId", "Created", "VoteDate" },
                values: new object[] { new Guid("d02c6bfb-fce6-4dbf-94ec-57991d2dfa4f"), new Guid("7d42621c-3756-4a82-bf2b-69fcfca6e0f2"), new DateTime(2022, 12, 23, 6, 30, 41, 149, DateTimeKind.Utc).AddTicks(3956), new DateTime(2022, 12, 23, 6, 30, 41, 149, DateTimeKind.Utc).AddTicks(3955) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("7a7ca13c-b54d-438b-ac64-bf0afb5f27ab"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("d02c6bfb-fce6-4dbf-94ec-57991d2dfa4f"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("cb06552d-4779-487d-a3ef-774406e705f9"));

            migrationBuilder.DeleteData(
                table: "votes",
                keyColumns: new[] { "CandidateId", "UserId" },
                keyValues: new object[] { new Guid("d02c6bfb-fce6-4dbf-94ec-57991d2dfa4f"), new Guid("7d42621c-3756-4a82-bf2b-69fcfca6e0f2") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "candidates",
                keyColumn: "Id",
                keyValue: new Guid("7a7ca13c-b54d-438b-ac64-bf0afb5f27ab"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "candidates",
                keyColumn: "Id",
                keyValue: new Guid("d02c6bfb-fce6-4dbf-94ec-57991d2dfa4f"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("7d42621c-3756-4a82-bf2b-69fcfca6e0f2"));

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpireDate",
                schema: "dbo",
                table: "products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
