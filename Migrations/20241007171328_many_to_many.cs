using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreRelation.Migrations
{
    /// <inheritdoc />
    public partial class many_to_many : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_StudentBooks_BookId",
                table: "StudentBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentBooks_StudentId",
                table: "StudentBooks",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentBooks_Books_BookId",
                table: "StudentBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentBooks_Students_StudentId",
                table: "StudentBooks",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentBooks_Books_BookId",
                table: "StudentBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentBooks_Students_StudentId",
                table: "StudentBooks");

            migrationBuilder.DropIndex(
                name: "IX_StudentBooks_BookId",
                table: "StudentBooks");

            migrationBuilder.DropIndex(
                name: "IX_StudentBooks_StudentId",
                table: "StudentBooks");
        }
    }
}
