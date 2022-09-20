using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "CAmount1",
                table: "Request",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CAmount2",
                table: "Request",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CAmount3",
                table: "Request",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CAmount4",
                table: "Request",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CAmountToString1",
                table: "Request",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CAmountToString2",
                table: "Request",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CAmountToString3",
                table: "Request",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CAmountToString4",
                table: "Request",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CMoneyCount1",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CMoneyCount2",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CMoneyCount3",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CMoneyCount4",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CMoneyType1",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CMoneyType2",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CMoneyType3",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CMoneyType4",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CTotalAmount",
                table: "Request",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CTotalAmountToString",
                table: "Request",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RjAmount1",
                table: "Request",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RjAmount2",
                table: "Request",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RjAmount3",
                table: "Request",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RjAmount4",
                table: "Request",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RjAmountToString1",
                table: "Request",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RjAmountToString2",
                table: "Request",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RjAmountToString3",
                table: "Request",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RjAmountToString4",
                table: "Request",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RjMoneyCount1",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RjMoneyCount2",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RjMoneyCount3",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RjMoneyCount4",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RjMoneyType1",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RjMoneyType2",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RjMoneyType3",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RjMoneyType4",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RjTotalAmount",
                table: "Request",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RjTotalAmountToString",
                table: "Request",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RtAmount1",
                table: "Request",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RtAmount2",
                table: "Request",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RtAmount3",
                table: "Request",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RtAmount4",
                table: "Request",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RtAmountToString1",
                table: "Request",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RtAmountToString2",
                table: "Request",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RtAmountToString3",
                table: "Request",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RtAmountToString4",
                table: "Request",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RtMoneyCount1",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RtMoneyCount2",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RtMoneyCount3",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RtMoneyCount4",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RtMoneyType1",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RtMoneyType2",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RtMoneyType3",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RtMoneyType4",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RtTotalAmount",
                table: "Request",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RtTotalAmountToString",
                table: "Request",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CAmount1",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "CAmount2",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "CAmount3",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "CAmount4",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "CAmountToString1",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "CAmountToString2",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "CAmountToString3",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "CAmountToString4",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "CMoneyCount1",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "CMoneyCount2",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "CMoneyCount3",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "CMoneyCount4",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "CMoneyType1",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "CMoneyType2",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "CMoneyType3",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "CMoneyType4",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "CTotalAmount",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "CTotalAmountToString",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RjAmount1",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RjAmount2",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RjAmount3",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RjAmount4",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RjAmountToString1",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RjAmountToString2",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RjAmountToString3",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RjAmountToString4",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RjMoneyCount1",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RjMoneyCount2",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RjMoneyCount3",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RjMoneyCount4",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RjMoneyType1",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RjMoneyType2",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RjMoneyType3",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RjMoneyType4",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RjTotalAmount",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RjTotalAmountToString",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RtAmount1",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RtAmount2",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RtAmount3",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RtAmount4",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RtAmountToString1",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RtAmountToString2",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RtAmountToString3",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RtAmountToString4",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RtMoneyCount1",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RtMoneyCount2",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RtMoneyCount3",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RtMoneyCount4",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RtMoneyType1",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RtMoneyType2",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RtMoneyType3",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RtMoneyType4",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RtTotalAmount",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RtTotalAmountToString",
                table: "Request");
        }
    }
}
