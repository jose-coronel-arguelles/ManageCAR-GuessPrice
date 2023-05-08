using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KForce.Service.Migrations
{
    /// <inheritdoc />
    public partial class AutoIncrementToPK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Doors",
                table: "Cars",
                newName: "Door");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Door",
                table: "Cars",
                newName: "Doors");
        }
    }
}
