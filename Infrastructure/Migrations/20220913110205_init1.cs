using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AtmCrs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtmCrs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LetterNo = table.Column<int>(type: "int", nullable: false),
                    CassetteSeries = table.Column<int>(type: "int", nullable: false),
                    DMoneyType1 = table.Column<int>(type: "int", nullable: true),
                    DMoneyCount1 = table.Column<int>(type: "int", nullable: true),
                    DAmount1 = table.Column<double>(type: "float", nullable: true),
                    DAmountToString1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DMoneyType2 = table.Column<int>(type: "int", nullable: true),
                    DMoneyCount2 = table.Column<int>(type: "int", nullable: true),
                    DAmount2 = table.Column<double>(type: "float", nullable: true),
                    DAmountToString2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DMoneyType3 = table.Column<int>(type: "int", nullable: true),
                    DMoneyCount3 = table.Column<int>(type: "int", nullable: true),
                    DAmount3 = table.Column<double>(type: "float", nullable: true),
                    DAmountToString3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DMoneyType4 = table.Column<int>(type: "int", nullable: true),
                    DMoneyCount4 = table.Column<int>(type: "int", nullable: true),
                    DAmount4 = table.Column<double>(type: "float", nullable: true),
                    DAmountToString4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DTotalAmount = table.Column<double>(type: "float", nullable: true),
                    DTotalAmountToString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtmCrsId = table.Column<int>(type: "int", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Request_AtmCrs_AtmCrsId",
                        column: x => x.AtmCrsId,
                        principalTable: "AtmCrs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Request_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestId = table.Column<int>(type: "int", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestStatus_Request_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestStatus_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Request_AtmCrsId",
                table: "Request",
                column: "AtmCrsId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_StatusId",
                table: "Request",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestStatus_RequestId",
                table: "RequestStatus",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestStatus_StatusId",
                table: "RequestStatus",
                column: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RequestStatus");

            migrationBuilder.DropTable(
                name: "Request");

            migrationBuilder.DropTable(
                name: "AtmCrs");

            migrationBuilder.DropTable(
                name: "Status");
        }
    }
}
