using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMigrationScripts.Migrations
{
    /// <inheritdoc />
    public partial class AddGroupIdColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Users",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Users");
        }
    }
}
