using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksMVC_MIST450sec01.Migrations
{
    /// <inheritdoc />
    public partial class changeColNametoTitleOfBooksTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Books",
                newName: "Title");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Books",
                newName: "Name");
        }
    }
}
