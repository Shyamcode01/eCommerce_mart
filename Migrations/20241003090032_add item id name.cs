using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_commerInventry.Migrations
{
    /// <inheritdoc />
    public partial class additemidname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "items",
                newName: "itemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "itemId",
                table: "items",
                newName: "Id");
        }
    }
}
