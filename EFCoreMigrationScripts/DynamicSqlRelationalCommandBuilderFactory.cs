using Microsoft.EntityFrameworkCore.Storage;

namespace EFCoreMigrationScripts
{
    public class DynamicSqlRelationalCommandBuilderFactory :
        RelationalCommandBuilderFactory
    {
        public DynamicSqlRelationalCommandBuilderFactory(
            RelationalCommandBuilderDependencies dependencies)
            : base(dependencies) { }

        public override IRelationalCommandBuilder Create()
            => new DynamicSqlRelationalCommandBuilder(Dependencies);
    }
}
