using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMigrationScripts.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                insert into Users (Name, GroupId) values ('User1', 0)
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
