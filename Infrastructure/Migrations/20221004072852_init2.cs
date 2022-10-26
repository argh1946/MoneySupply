using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FileType",
                table: "FileAttachment",
                newName: "FileTypeId");

            migrationBuilder.CreateTable(
                name: "FileType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileType", x => x.Id);
                });

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

            migrationBuilder.DropTable(
                name: "FileType");

            migrationBuilder.DropIndex(
                name: "IX_FileAttachment_FileTypeId",
                table: "FileAttachment");

            migrationBuilder.RenameColumn(
                name: "FileTypeId",
                table: "FileAttachment",
                newName: "FileType");
        }
    }
}
