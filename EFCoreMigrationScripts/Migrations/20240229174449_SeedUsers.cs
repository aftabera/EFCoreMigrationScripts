using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMigrationScripts.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                insert into Users values ('Name1', 'abc1@xyz.com', 'xxx')
                insert into Users values ('Name2', 'abc2@xyz.com', 'xxx')
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
