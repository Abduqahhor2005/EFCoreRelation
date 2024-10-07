using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreRelation.Migrations
{
    /// <inheritdoc />
    public partial class add_unique_to_countryid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Type_CategoryId",
                table: "Type");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Type_CategoryId",
                table: "Type",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Type_CategoryId",
                table: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_Type_CategoryId",
                table: "Type",
                column: "CategoryId",
                unique: true);
        }
    }
}
