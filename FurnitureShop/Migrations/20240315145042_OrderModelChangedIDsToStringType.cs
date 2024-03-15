using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FurnitureShop.Migrations
{
    /// <inheritdoc />
    public partial class OrderModelChangedIDsToStringType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderedFurnitureIDs",
                table: "Orders",
                newName: "OrderedFurnitureNames");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderedFurnitureNames",
                table: "Orders",
                newName: "OrderedFurnitureIDs");
        }
    }
}
