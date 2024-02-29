using Microsoft.EntityFrameworkCore.Storage;

namespace EFCoreMigrationScripts
{
    public class DynamicSqlRelationalCommandBuilder : RelationalCommandBuilder
    {
        public DynamicSqlRelationalCommandBuilder(
            RelationalCommandBuilderDependencies dependencies)
            : base(dependencies) => base.Append("EXECUTE ('");

        public override IRelationalCommandBuilder Append(string value)
            => base.Append(value.Replace("'", "''"));

        public override IRelationalCommand Build()
        {
            base.Append("')");
            return base.Build();
        }
    }
}
