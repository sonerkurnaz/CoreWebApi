﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HttpStatusCode.Migrations
{
    public partial class initDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sehirler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SehirAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehirler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ilceler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlceAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SehirId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SehirId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilceler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ilceler_Sehirler_SehirId1",
                        column: x => x.SehirId1,
                        principalTable: "Sehirler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "Description", "Name", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 4, 11, 23, 15, 120, DateTimeKind.Local).AddTicks(7287), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elektronik", "Elektronik", 0, null },
                    { 2, new DateTime(2022, 7, 4, 11, 23, 15, 120, DateTimeKind.Local).AddTicks(7297), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tekstil", "Tekstil", 0, null },
                    { 3, new DateTime(2022, 7, 4, 11, 23, 15, 120, DateTimeKind.Local).AddTicks(7300), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yiyecek", "Yiyecek", 0, null },
                    { 4, new DateTime(2022, 7, 4, 11, 23, 15, 120, DateTimeKind.Local).AddTicks(7300), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İçecek", "İçecek", 0, null },
                    { 5, new DateTime(2022, 7, 4, 11, 23, 15, 120, DateTimeKind.Local).AddTicks(7300), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nalburiye", "Nalburiye", 0, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ilceler_SehirId1",
                table: "Ilceler",
                column: "SehirId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Ilceler");

            migrationBuilder.DropTable(
                name: "Sehirler");
        }
    }
}
