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
                name: "MoneyType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoneyType", x => x.Id);
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
                    AtmCrsId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    RequestType = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LetterNo = table.Column<int>(type: "int", nullable: false),
                    CassetteSeries = table.Column<int>(type: "int", nullable: false),
                    Remaining = table.Column<int>(type: "int", nullable: false),
                    Excess = table.Column<int>(type: "int", nullable: false),
                    DMoneyType1 = table.Column<int>(type: "int", nullable: true),
                    DMoneyCount1 = table.Column<int>(type: "int", nullable: true),
                    DAmount1 = table.Column<double>(type: "float", nullable: true),
                    DAmountToString1 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DMoneyType2 = table.Column<int>(type: "int", nullable: true),
                    DMoneyCount2 = table.Column<int>(type: "int", nullable: true),
                    DAmount2 = table.Column<double>(type: "float", nullable: true),
                    DAmountToString2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DMoneyType3 = table.Column<int>(type: "int", nullable: true),
                    DMoneyCount3 = table.Column<int>(type: "int", nullable: true),
                    DAmount3 = table.Column<double>(type: "float", nullable: true),
                    DAmountToString3 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DMoneyType4 = table.Column<int>(type: "int", nullable: true),
                    DMoneyCount4 = table.Column<int>(type: "int", nullable: true),
                    DAmount4 = table.Column<double>(type: "float", nullable: true),
                    DAmountToString4 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DTotalAmount = table.Column<double>(type: "float", nullable: true),
                    DTotalAmountToString = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CMoneyType1 = table.Column<int>(type: "int", nullable: true),
                    CMoneyCount1 = table.Column<int>(type: "int", nullable: true),
                    CAmount1 = table.Column<double>(type: "float", nullable: true),
                    CAmountToString1 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CMoneyType2 = table.Column<int>(type: "int", nullable: true),
                    CMoneyCount2 = table.Column<int>(type: "int", nullable: true),
                    CAmount2 = table.Column<double>(type: "float", nullable: true),
                    CAmountToString2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CMoneyType3 = table.Column<int>(type: "int", nullable: true),
                    CMoneyCount3 = table.Column<int>(type: "int", nullable: true),
                    CAmount3 = table.Column<double>(type: "float", nullable: true),
                    CAmountToString3 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CMoneyType4 = table.Column<int>(type: "int", nullable: true),
                    CMoneyCount4 = table.Column<int>(type: "int", nullable: true),
                    CAmount4 = table.Column<double>(type: "float", nullable: true),
                    CAmountToString4 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CTotalAmount = table.Column<double>(type: "float", nullable: true),
                    CTotalAmountToString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RjMoneyType1 = table.Column<int>(type: "int", nullable: true),
                    RjMoneyCount1 = table.Column<int>(type: "int", nullable: true),
                    RjAmount1 = table.Column<double>(type: "float", nullable: true),
                    RjAmountToString1 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    RjMoneyType2 = table.Column<int>(type: "int", nullable: true),
                    RjMoneyCount2 = table.Column<int>(type: "int", nullable: true),
                    RjAmount2 = table.Column<double>(type: "float", nullable: true),
                    RjAmountToString2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    RjMoneyType3 = table.Column<int>(type: "int", nullable: true),
                    RjMoneyCount3 = table.Column<int>(type: "int", nullable: true),
                    RjAmount3 = table.Column<double>(type: "float", nullable: true),
                    RjAmountToString3 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    RjMoneyType4 = table.Column<int>(type: "int", nullable: true),
                    RjMoneyCount4 = table.Column<int>(type: "int", nullable: true),
                    RjAmount4 = table.Column<double>(type: "float", nullable: true),
                    RjAmountToString4 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    RjTotalAmount = table.Column<double>(type: "float", nullable: true),
                    RjTotalAmountToString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RtMoneyType1 = table.Column<int>(type: "int", nullable: true),
                    RtMoneyCount1 = table.Column<int>(type: "int", nullable: true),
                    RtAmount1 = table.Column<double>(type: "float", nullable: true),
                    RtAmountToString1 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    RtMoneyType2 = table.Column<int>(type: "int", nullable: true),
                    RtMoneyCount2 = table.Column<int>(type: "int", nullable: true),
                    RtAmount2 = table.Column<double>(type: "float", nullable: true),
                    RtAmountToString2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    RtMoneyType3 = table.Column<int>(type: "int", nullable: true),
                    RtMoneyCount3 = table.Column<int>(type: "int", nullable: true),
                    RtAmount3 = table.Column<double>(type: "float", nullable: true),
                    RtAmountToString3 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    RtMoneyType4 = table.Column<int>(type: "int", nullable: true),
                    RtMoneyCount4 = table.Column<int>(type: "int", nullable: true),
                    RtAmount4 = table.Column<double>(type: "float", nullable: true),
                    RtAmountToString4 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    RtTotalAmount = table.Column<double>(type: "float", nullable: true),
                    RtTotalAmountToString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Creator = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Request_AtmCrs_AtmCrsId",
                        column: x => x.AtmCrsId,
                        principalTable: "AtmCrs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    RequestId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestStatus_Request_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestStatus_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Request_AtmCrsId",
                table: "Request",
                column: "AtmCrsId");

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
                name: "MoneyType");

            migrationBuilder.DropTable(
                name: "RequestStatus");

            migrationBuilder.DropTable(
                name: "Request");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "AtmCrs");
        }
    }
}
