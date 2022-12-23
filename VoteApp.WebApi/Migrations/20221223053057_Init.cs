using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoteApp.WebApi.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "candidates",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "politics",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PoliticDocInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartyName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_politics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_politics_candidates_Id",
                        column: x => x.Id,
                        principalSchema: "dbo",
                        principalTable: "candidates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "products",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(12,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_candidates_Id",
                        column: x => x.Id,
                        principalSchema: "dbo",
                        principalTable: "candidates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "votes",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CandidateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VoteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_votes", x => new { x.UserId, x.CandidateId });
                    table.ForeignKey(
                        name: "FK_votes_candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalSchema: "dbo",
                        principalTable: "candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_votes_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_votes_CandidateId",
                table: "votes",
                column: "CandidateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "politics",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "products",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "votes");

            migrationBuilder.DropTable(
                name: "candidates",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
