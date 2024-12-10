using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClubMembershipApplication.Migrations
{
    /// <inheritdoc />
    public partial class CorrectUserAddressFirstLine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdressFirstLine",
                table: "Users",
                newName: "AddressFirstLine");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddressFirstLine",
                table: "Users",
                newName: "AdressFirstLine");
        }
    }
}
