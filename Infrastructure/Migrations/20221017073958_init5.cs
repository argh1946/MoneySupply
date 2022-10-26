using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_FileAttachment_FileTypeId",
                table: "FileAttachment",
                column: "FileTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_FileAttachment_FileType_FileTypeId",
                table: "FileAttachment",
                column: "FileTypeId",
                principalTable: "FileType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileAttachment_FileType_FileTypeId",
                table: "FileAttachment");

            migrationBuilder.DropIndex(
                name: "IX_FileAttachment_FileTypeId",
                table: "FileAttachment");
        }
    }
}
