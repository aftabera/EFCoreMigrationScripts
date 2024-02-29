using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMigrationScripts.Migrations
{
    /// <inheritdoc />
    public partial class RemoveGroupIdColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Users",
                type: "int",
                nullable: true);
        }
    }
}
