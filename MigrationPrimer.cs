using NHibFluent.Model;

namespace NHibFluent
{
    public class MigrationPrimer: NHibFluentModel
    {
        public MigrationPrimer()
        {
            AlterTable("my_table")
                .AddColumn(columnName: "name", columnType: typeof(string), canNull: true)
                .DefaultValue(value: null);
        }
    }
}